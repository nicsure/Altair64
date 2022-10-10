#ifndef INTEL8080_H_
#define INTEL8080_H_

#ifndef DLLIMPORT8080
    #define DLL __declspec(dllexport)
#else
    #define DLL __declspec(dllimport)
#endif

#include "pch.h"

// Code by nicsure (C)2022
// https://www.youtube.com/nicsure

typedef void(__stdcall* VoidCall)();
typedef bool(__stdcall* BoolCall)();

extern "C"
{
    typedef void(__stdcall* PortOutCallback)(UINT8, UINT8);

    typedef UINT8(__stdcall* PortInCallback)(UINT8);

    typedef void(__stdcall* StatusCallback)(UINT8*, UINT8*, bool);

    /// <summary>
    /// Abstract Function definition that deals with external memory mapping.
    /// The function deals with both reading and writing.
    /// This can be implemented to remap all or some of the memory the emulator uses. It may also be used to simply monitor memory access.
    /// </summary>
    /// <param name="UINT8 mode"> - Specifies if the call is a read (PEEK=0x00) or write (POKE=0x01)</param> 
    /// <param name="UINT16 addr"> - The address of the byte in memory being accessed</param> 
    /// <param name="UINT16 val"> - For a read, this contains what value is in the emulator's built-in RAM, you may or may not wish to use this. For a write, it contains the value that is being written to the address</param> 
    /// <returns>UINT8 - For a read, the return value should be the byte at that address of the externally mapped memory. You can of course just return val if all you want to do is monitor memory reads. For a write, the return value will be placed in the emulator's built-in RAM which is only critical if all you are doing is monitoring.</returns>
    typedef UINT8(__stdcall* RamCallback)(UINT8, UINT16, UINT8);


    /// <summary>
    /// Initializes the emulator but does not start it, needs to be called before Start().
    /// Init and Shutdown should both be called from the same Thread
    /// </summary>
    /// <param name="UINT8 PortInCallback(UINT8 port)"> - External method that receives Port In requests</param>
    /// <param name="void PortOutCallback(UINT8 port, UINT8 data)"> - External method that receives Port Out requests</param>
    /// <param name="void StatusCallback(UINT8* status, UINT8* state, bool isRunning)"> - External method that receives status updates. This parameter may be NULL in which case status updates will be disabled and SHOULD NOT be enabled</param>
    /// <param name="UINT16 speed"> - Requested speed of the emulator in nanoseconds per TState</param>
    DLL void Init(PortInCallback, PortOutCallback, StatusCallback, UINT16);

    /// <summary>
    /// Starts the emulator after initialization. The emulator is placed into Step mode. This will block the thread until ShutDown() is called.
    /// This should be called from a different thread to Init and Shutdown.
    /// </summary>
    DLL void Start();

    /// <summary>
    /// Shuts down the emulator causing the Start() method to exit.
    /// Init and Shutdown should both be called from the same Thread
    /// </summary>
    DLL void ShutDown();

    /// <summary>
    /// Changes the speed of the emulator. A theoretical speed of 1GHz is the maximum
    /// (1 nanosecond per TState), but in reality the speed will max out lower than that
    /// and will depend on the speed of the host system. It is recommended to only change the speed
    /// while in Step mode.
    /// </summary>
    /// <param name="UINT16 speed"> - Requested speed of the emulator in nanoseconds per TState</param>
    DLL void Speed(UINT16);

    /// <summary>
    /// Puts the emulator into Run mode,
    /// </summary>
    DLL void Run();

    /// <summary>
    /// Puts the emulator into Step mode
    /// </summary>
    DLL void Stop();

    /// <summary>
    /// When in Step mode, calling this will make the emulator execute a single instruction
    /// </summary>
    DLL void Step();

    /// <summary>
    /// Performs a soft reset. All registers and flags are cleared and the program counter is set to 0x0000.
    /// If the emulator was in Run mode, it will remain in Run mode, executing from 0x0000
    /// </summary>
    DLL void Reset();

    /// <summary>
    /// Performs a hard reset. All registers, flags and RAM are cleared and the program counter is set to 0x0000.
    /// If the emulator was in Run mode, it will stop and switch to Step mode.
    /// </summary>
    DLL void HardReset();

    /// <summary>
    /// Returns a byte array pointer containing the current system state, this includes all registers, flags and memory.
    /// Although not forbidden, it is unwise to call this while in Run mode.
    /// </summary>    
    /// <returns>UINT8* - 65792 length byte array</returns>
    DLL UINT8* State();

    /// <summary>
    /// Requests an Interrupt is fired
    /// </summary>
    /// <param name="UINT8 vector - The opcode of the RST instruction for the interrupt"></param>
    DLL void Interrupt(UINT8);

    /// <summary>
    /// Returns the byte in RAM at the specified address
    /// </summary>
    /// <param name="UINT16 addr"> - Address to peek</param>
    /// <returns>UINT8 - The value at the address</returns>
    DLL UINT8 Examine(UINT16);

    /// <summary>
    /// Sets the byte in RAM at the specified address to the specified value if the area is not marked as being ROM
    /// </summary>
    /// <param name="UINT16 addr"> - Address to poke</param>
    /// <param name="UINT8 data"> - Value to poke</param>
    DLL void Deposit(UINT16, UINT8);

    /// <summary>
    /// Copies data from a byte array to the emulator's RAM.
    /// This function is cumbersome to implement with C#'s P/Invoke. Instead use State() to pass back an IntPtr and use Marshal.Copy() to copy data to RAM.
    /// </summary>
    /// <param name="UINT8* data"> - Byte array to copy from</param>
    /// <param name="UINT16 addr"> - Address in RAM to copy to</param>
    /// <param name="UINT16 len"> - Length of data to copy in bytes</param>
    /// <returns></returns>
    DLL void ToRam(UINT8*, UINT16, UINT16);

    /// <summary>
    /// Turns Status reporting on or off. When off, a faster maximum speed can be achieved but you lose the blinky lights.
    /// </summary>
    /// <param name="BOOL b"> - TRUE for on, FALSE for off</param>
    /// <returns></returns>
    DLL void SetDoStatus(bool);

    /// <summary>
    /// Returns a BOOL indicating if the emulator is in running mode.
    /// </summary>
    /// <returns>BOOL - TRUE=Running FALSE=Not Running</returns>
    DLL bool IsRunning();

    /// <summary>
    /// Marks a memory area as being ROM. ROM cannot be written to by the CPU or the Deposit() function. ToRam() and State() can however still be used to set ROM memory.
    /// </summary>
    /// <param name="UINT16 start"> - Address of the start of the ROM area</param>
    /// <param name="UINT16 end"> - Address at the end of the ROM area</param>
    /// <returns></returns>
    DLL void SetROM(UINT16, UINT16);

    /// <summary>
    /// Marks a memory area as being RAM.
    /// </summary>
    /// <param name="UINT16 start"> - Address of the start of the RAM area</param>
    /// <param name="UINT16 end"> - Address at the end of the RAM area</param>
    /// <returns></returns>
    DLL void SetRAM(UINT16, UINT16);

    /// <summary>
    /// Marks a memory area as externally mapped using the passed RamCallback to handle reads and writes
    /// </summary>
    /// <param name="UINT16 start"> - Address of the start of the external memory area</param>
    /// <param name="UINT16 end"> - Address at the end of the external memory area</param>
    /// <param name="RamCallback callBack"> - Pointer to the external function that deals with this memory area.</param>
    /// <returns></returns>
    DLL void SetExternal(UINT16, UINT16, RamCallback);


    /// <summary>
    /// Just used during testing of the code, unimportant.
    /// </summary>
    DLL int TestDLL();
}

void EXECUTE(UINT8);
void RESET(bool);
UINT8 RAM8(UINT16);
void RAM8(UINT16, UINT8);
void UPDATE(UINT16, UINT8);
void LOOP();
void STATUSCALLBACK();

#endif