using Nicsure.Altair8800.Hardware.Interfaces;
using Nicsure.General;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;

namespace Nicsure.Altair8800.Hardware
{
    public class Modem : SerialController, IShutDownAble
    {
        // Code by nicsure (C)2022
        // https://www.youtube.com/nicsure

        private NetworkStream stream = null;
        private TcpListener listener;
        private TcpClient client;
        private String cmd = String.Empty;
        private bool commandMode = true, shutDown = false, addLF = false;
        private int cmdEscape = 0;
        private readonly Stopwatch escapeTimer = new();

        public Modem() : base(SerialCardType.SIO2, 18, 19)
        {
            CallBack = ByteIn;
            Task.Run(Listen);
        }

        private void Online()
        {
            commandMode = false;
            escapeTimer.Restart();
            cmdEscape = 0;
        }

        private void NoCarrier()
        {
            stream = null;
            escapeTimer.Stop();
            commandMode = true;
            SendString("\r\nNO CARRIER\r\n");
        }

        private void Listen()
        {
            while (!shutDown) // loop until we shut down the app
            {
                try // exceptions' lives matter
                {
                    listener = new TcpListener(IPAddress.Loopback, 7880); // create a listening socket but don't start it yet
                    if (stream != null) // check if there's a network connection established, this could be an incoming or outgoing connection 
                    {
                        using (TcpClient _ = client) // ensure we dispose the TcpClient
                        {
                            using NetworkStream tcp = stream; // and dispose the Stream
                            Online(); // online mode
                            while (!shutDown) // loop while the system is running
                            {
                                int c = tcp.ReadByte(); // recieve a byte from whoever's connected over the network
                                if (c == -1) break; // exit the loop if the connection has dropped
                                Send(c); // send the byte to the serial controller's user data buffer so the software running on the Altair can retrieve it
                                if (c == 13 && addLF) // if the character is a carriage return and we have the LF flag set
                                    Send(10); // send a LF right after
                            }
                        }
                        NoCarrier(); // offline mode
                    }
                    // we end up here if a connection has been correctly dropped
                    // or if there was no connection present at the start of the loop
                    listener.Start(); // start listening for incoming connections
                    client = listener.AcceptTcpClient(); // sit and wait for an incoming connection
                    stream = client.GetStream(); // esablish the network stream for communication. This object not being null also indicates to the rest of the class that there is a connection present
                    // we now restart the loop with a valid Stream object so the start of the loop will begin to relay data rather than sitting waiting for a connection again
                }
                catch (ObjectDisposedException) { NoCarrier(); } // this exception occurs when the connection is "Hung Up" by the user. In this case we need to enter offline mode to null out the stream object so we don't attempt to use it
                catch (Exception) { Thread.Sleep(500); } // this exception will occur because the listening socket has been killed. This happens when an outgoing connection has been established. At this point the stream object has been set elsewhere
                Mon.KillListener(listener); // Obliterate the old listening socket, this is just voilence for the sake of violence
            }
        }

        public override int RequestRead(int port)
        {
            int reply = base.RequestRead(port);
            if (port == ControlPort && stream == null)
                reply |= 12; // CTS and DCD are inverse logic
            return reply;
        }

        private bool ConnectTo(String host, int port)
        {
            if (stream == null) // only connect if we aren't already connected somewhere
            {
                try // networking is unreliable
                {
                    client = new TcpClient(host, port); // attempt to connect
                    stream = client.GetStream(); // and get the communication stream
                }
                catch (Exception) // summat's wrong our kid
                {
                    Mon.Err("[Modem] Cannot connect to " + host + ":" + port); // report error
                    stream = null; // clean up
                    return false; // exit method indicationg FAIL
                }
                Mon.KillListener(listener); // now we have successfully connected, we need to make the data pump loop stop listening for connections, we do this by murdering the listening socket. This causes the currently blocked thread waiting for a connection to generate an exception, we catch that exception and start the data pump
                return true; // indicate WIN!
            }
            else
                Mon.Err("[Modem] Already connected to a host."); // report already connected status
            return false; // indicate STUPID
        }

        public void HangUp()
        {
            stream?.Close(); // close the network stream. This causes the data pump thread to generate an exception which we then catch, that thread then tidies up a bit and starts to listen for incoming connections.
        }

        private void SendString(String s) // sends a string to the Altair as incoming serial data
        {
            foreach (char c in s) // just send each character in the string to the user data buffer. 
                Send(c);
        }

        private void Command(String command)
        {
            String c = command.ToLower().Trim(); // convert to lower case and remove white space from start and end
            while (c.IndexOf("  ") != -1) c = c.Replace("  ", " "); // make sure we only have 1 space between stuff
            if (c.StartsWith("ato")) // command to go to online mode
            {
                if (stream == null) // we need to have an active connection for this
                    SendString("NOT CONNECTED\r\n"); // report problem
                else
                {
                    Online(); // online mode
                    SendString("ONLINE\r\n"); // report status
                }
            }
            else if (c.StartsWith("ath")) // command to disconnect (Hang up) the current connection
            {
                HangUp();
            }
            else if (c.StartsWith("atd")) // DIAL command. Used to establish an outgoing connection to a host.
            {
                if (stream != null) // only do this if we're not already connected
                {
                    SendString("A CONNECTION IS ALREADY ESTABLISHED\r\n"); // report problem
                    return; // exit method
                }
                String[] p = c.Split(' '); // split up command into parts that are seperated by spaces
                if (p.Length > 1) // there needs to be at least 2 parts to the command
                {
                    String[] h = p[1].Split(':'); // split the second part into parts that are seperated by a colon, this is for the port number
                    if (h.Length <= 2) // port is optional but make sure there's no extraneous data
                    {
                        int port = 23; // default port is 23 (telnet)
                        String host = h[0]; // the hostname of where we're connecting to is the first part
                        if (h.Length == 1 || int.TryParse(h[1], out port)) // if a port is not suppplied, or the port supplied is a valid number
                        {
                            if (ConnectTo(host, port)) // attempt to connect
                            {
                                SendString("CONNECT 115200\r\n"); // send success report
                                addLF = c.StartsWith("atdlf"); // see if we need to enable the linefeed flag
                            }
                            else
                                SendString("NO ANSWER\r\n"); // send failure report
                            return; // exit method. Do you like multiple exit points? Do they trigger you? Too bad bud!
                        }
                    }
                }
                Mon.Err("[Modem] Bad connect command"); // if we get here, something more serious is wrong
                SendString("NO DIALTONE\r\n"); // send a different (modem friendly) failure report 
                return; // exit method
            }
            SendString("OK\r\n"); // always send OK after everything typed in, to appease any init strings sent by whatever is running on the Altair
        }

        private void ByteIn(SerialController _) // a byte has been receieved from the Altair
        {
            int byt = Get(); // GET IT
            if (commandMode) // if we're in command mode
            {
                switch (byt) // some bytes are SPECIAL!
                {
                    case 13: // Return pressed
                        SendString("\r\n"); // send new line
                        Command(cmd); // execute whatever cammand has been entered previously
                        cmd = String.Empty; // reset the "cmd" string, this is used to construct the command string byte by byte
                        break;
                    case 8: // back space
                        cmd = Mon.TruncStringBy(cmd, 1); // remove one character from the end of cmd
                        SendString("\b \b"); // send a backspace, a space and another backspace to the Altair
                        break;
                    default: // anything else
                        cmd += Mon.Ascii(byt); // add the ascii character of the byte to the command string 
                        Send(byt); // also echo it back to the Altair
                        break;
                }
            }
            else // otherwise we're in online mode
            {
                if (byt == 43) // test for the escape character +
                {
                    if ((cmdEscape == 0 && escapeTimer.ElapsedMilliseconds > 2000) || cmdEscape > 0) // test if incoming data from the Altair has been idle for at least two seconds, or if we already have recieved a + previously after a two second idle
                        cmdEscape++; // add one to the counter keeping tack of how many +'s we've recieved correctly
                    if (cmdEscape == 3) // if we've recieved 3 +'s
                    {
                        commandMode = true; // switch to command mode, but keep the connection active
                        SendString("\r\nESCAPE TO COMMAND MODE\r\nOK\r\n"); // report status
                        escapeTimer.Stop(); // stop the stopwatch, we don't need it running in command mode
                        return; // exit method
                    }
                }
                else // otherwise, it's not a + character
                {
                    cmdEscape = 0; // Reset the + counter
                    escapeTimer.Restart(); // restart the idle timer
                }
                try // stuff will go wrong if it can go wrong
                {
                    stream?.WriteByte((byte)byt); // send the byte to the connected host
                    if (byt == 13 && addLF) // if the byte is a CR and we need to add a LF
                        stream?.WriteByte(10); // send a LF
                }
                catch (Exception) { }
            }
        }

        public void ShutDown()
        {
            shutDown = true;
            HangUp();
            Mon.KillListener(listener);
        }
    }
}