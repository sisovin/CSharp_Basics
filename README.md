# C# Programming Language

## C# Overview

C# (C Sharp) is a general-purpose, statically typed, object-oriented programming language that was founded in 2000 by Microsoft as part of their .NET Initiative.

C# was designed to be portable and fast and is tightly coupled with Microsoft’s .NET Framework. It was created alongside the .NET framework in the late 90s.

C# is one of the most popular programming languages in the world and can be used to write applications on almost every platform including Windows, Mac, iOS, Android, and Linux.

In fact, more and more people are using C# to write cross-platform apps every day because it allows for a shared code base across platforms. Basically, you could write all of your backend business logic and database management code once, and use it on iPhone, Android, and desktop.

C# supports modern programming paradigms such as asynchronous programming, functional programming, and LINQ (Language Integrated Query) for data manipulation. It also has a rich set of libraries and frameworks, including ASP.NET for web development, Xamarin for mobile development, and Unity for game development.

## How C# Runs

All C# code is compiled down into an intermediate language called Common Intermediate Language (CIL), which is then translated and executed by the .NET runtime, also called the Common Language Runtime (CLR). This ensures that C# programs can be run on virtually any combination of hardware and operating system.

The underlying C# runtime uses an automatic garbage collector to manage memory, and the syntax of C# is largely influenced by Java. C# also includes features such as exception handling, type safety, and strong typing to ensure robust and reliable code.

## Choosing an IDE

Most developers choose to write C# using a specialized integrated development environment called Visual Studio. Visual Studio is an IDE that is maintained and developed by Microsoft, so it’s the best choice and realistically the only choice for writing C# applications.

Visual Studio provides a comprehensive set of tools for C# development, including a powerful code editor, debugging tools, and project management features. It also supports extensions and plugins to enhance the development experience.

## Setting Up Visual Studio Code for C #

Visual Studio Code (VS Code) is a lightweight, open-source code editor that can be used for C# development. To set up VS Code for C#, you need to install the C# extension, which provides support for IntelliSense, debugging, and other features.

## Compiling and Running C# Programs on Windows

### Prerequisites

1. Download and install the .NET SDK from the official Microsoft website.
2. Check if the .NET SDK is available on your PC by running `dotnet --list-sdks` in the command prompt.
3. Add the .NET SDK to your system PATH.
4. Verify the installation by running `dotnet --version` in the command prompt. You should see the version number, such as `9.0.101`.

```markdown


### Steps to Compile and Run

The `dotnet run` command is related to these steps and can be used as an alternative to `csc`. Here's an explanation:

- `csc` stands for C# Compiler, which is used to compile C# source files into executable programs.
- `dotnet run` is a command that builds and runs your application in one step, simplifying the process.

These are the following steps using `dotnet run`:

1. Open a terminal and navigate to the project directory:
   ```sh
   cd D:/CGroupProjects/CSharp_Basics
   ```

2. Create a new console project (if not already created):

   ```sh
   dotnet new console -o Printing
   ```

3. Replace the content of the generated `Program.cs` file with your `hello.cs` content:

   ```csharp
   // filepath: /d:/CGroupProjects/CSharp_Basics/Printing/Program.cs
   /* **********************************
    * Printing/Program.cs
    * **********************************/
   // Path: D:/CGroupProjects/CSharp_Basics/Printing/Program.cs
   // Run: D:\CGroupProjects\CSharp_Basics>dotnet run
   // Output: Hello, World!

   using System;

   class Program
   {
       static void Main(string[] args)
       {
           Console.WriteLine("Hello, World!");
       }
   }
   ```

4. Navigate to the Printing directory:

   ```sh
   cd Printing
   dotnet run --project Printing
   ```

5. Run the project:

   ```sh
   dotnet run
   
   ```
6. Verify the output directory for the executable:

```sh
  ls D:/CGroupProjects/CSharp_Basics/Printing/bin/Debug/net9.0/
```

7. Run the executable directly from the output directory:

```sh
  D:\CGroupProjects\CSharp_Basics> ./Printing/bin/Debug/net9.0/Printing.exe
```

This will compile and run your `hello.cs` (now `Program.cs`) file, and you should see the output:

```
Hello, World!
```

### Debugging and Project Management

#### Debugging C# Programs

Visual Studio and Visual Studio Code both provide powerful debugging tools for C# programs. You can set breakpoints, inspect variables, and step through code to identify and fix issues.

#### Adding the Project to GitHub

To add your C# project to GitHub, you need to initialize a Git repository, add your files, commit your changes, and push the repository to GitHub.

#### Update the Existing Remote

To update the existing remote repository, you can use the `git remote set-url` command to change the URL of the remote repository.

#### Remove the Existing Remote and Add Again

To remove the existing remote repository, use the `git remote remove` command. Then, you can add a new remote repository using the `git remote add` command.

## Troubleshooting Common Issues

Common issues in C# development include missing references, version conflicts, and runtime errors. You can use the built-in tools in Visual Studio and Visual Studio Code to diagnose and fix these issues. Additionally, the .NET documentation and community forums are valuable resources for troubleshooting and finding solutions to common problems.
