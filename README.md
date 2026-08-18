Step 1: Install the .NET SDK

Go to the official .NET download page:

Download the .NET SDK - https://dotnet.microsoft.com/en-us/

Download the latest .NET SDK for Windows x64 (not the Runtime).

Install it using the default options.

Step 2: Install Visual Studio Code

Visual Studio Code - https://code.visualstudio.com/download?_exp_download=d53503e735

Install it with the default settings.

Step 3: Install the C# Extension
Open VS Code.
Click the Extensions icon (or press Ctrl + Shift + X).
Search for C#.
Install the C# extension published by Microsoft.

Step 4: Verify the .NET SDK

Open Command Prompt and run:

dotnet --version

You should see something like:

10.0.xxx

If you do, the SDK is installed correctly.

Step 5: Create your first C# project

Open Command Prompt and run:

1.  mkdir HelloCSharp
2.  cd HelloCSharp
3.  dotnet new console

This creates a new console application.

Step 6: To Open the project in VS Code

In the same folder (inside cmd), run:

code . (give space after code)

VS Code will open your project.

Step 7: Run the program

In the VS Code terminal, run:

dotnet run

You should see:

Hello, World!
