Here is my very untidy Altair 8800 emulator project solution. This was put together with Visual Studio 2022 using .NET 6.0. Although .NET 6 will use enforced nullables by default I have disabled this as converting the previous .net framework 4 code to nullables would have been far too much work,  

I am not at all happy with the awful state of the code in this project, but I really do not have much free time to get it into a state that doesn't make me cringe. There are almost certainly still bugs and glitches, so don't expect too much. Nothing is code documented either. I am slowly cleaning things up, but this project balooned into a massive one and there's still a lot of work to do in that area and I'm just one guy.

The code (such as it is) is completely public domain and open, so do with it as you will. All I ask is that you don't remove my copyright messages and links to my YouTube channel.

The project should be completelty self-contained and only requires the NuGet NAudio package to be installed for the cassette audio feature. This should be automatically installed when you first open the project in Visual Studio 2022, but if not, just open the NuGet project manager and install it.

I'd recommend building for x64 platforms.

Make sure you build the solution before attempting to open the Form designer because there are custom controls that need to be compiled beforehand.

There is an odd "Object reference not set to an instance of an object" error that pops up when opening the main UI in the designer. Not sure why that happens but it doesn't seem to cause any issues, just ignore it.

A brief demo of this application is on my YouTube channel, although this is somewhat outof date now.
https://www.youtube.com/watch?v=GLT6EjQuxTs

When messing with cassette audio and trying to load in audio data, I have found that setting the hysteresis to a higher value than the default tends to work better. Around 55% for me seems optimal, YMMV.

The core 8080 C++ code doesn't use any Windows APIs (I think) so it should be portable to other platforms easily enough. The 8080 code is static and thus only capable of emulating a single CPU. Objectification for multiple instances is something I am planning, but frankly, I don't see much use case for that.

PuTTY embedding is implemented but is very sketchy atm. Right clicking the PUTTY option in the terminal window will allow you to mess with the settings. PuTTY must be configured with a specific saved session for use with the emulator. The default name is "Altair8800" but this can be changed in the settings. The "PuTTY TitleBar Height" option in the settings is a bit of cludge. Since there's no apparent way to surpress the PuTTY window's title bar, this setting moves the top of the terminal window up by some amount in order to hide the title bar. Depending on your system's theme, DPI and scaling settings, this value may need to be tweaked.
Recommended (and default) Settings for the PuTTY session are:
Saved Session > Altair8800
Connection type > Raw
Host Name (or IP address) > 127.0.0.1
Port > 7870
Terminal > Local Echo = Force Off
Terminal > Local Line Editing = Force Off
Terminal > Keyboard > The Backspace Key = Control H
Window > Display scrollbar = Off

