Here is my very untidy Altair 8800 emulator project solution. This was put together with Visual Studio 2022 using .NET 6.0

I am not at all happy with the awful state of the code in this project, but I really do not have the time to get it in a state that doesn't make me cringe. There are almost certainly still bugs and glitches, so don't expect too much. Nothing is code documented either.

The code (such as it is) is completely public domain and open, so do with it as you will. All I ask is that you don't remove my copyright messages and links to my YouTube channel.

The project should be completelty self-contained and only requires the NuGet NAudio package to be installed for the cassette audio feature. This should be automatically installed when you first open the project in Visual Studio 2022, but if not, just open the NuGet project manager and install it.

I'd recommend building for x64 platforms.

Make sure you build the solution before attempting to open the Form designer because there are custom controls that need to be compiled beforehand.

There is an odd "Object reference not set to an instance of an object" error that pops up when opening the main UI in the designer. Not sure why that happens but it doesn't seem to cause any issues, just ignore it.

A brief demo of this application is on my YouTube channel
https://www.youtube.com/watch?v=GLT6EjQuxTs
