/* **********************************
 * UserInput/UserInput.cs
 * **********************************/
// Path: D:/CGroupProjects/CSharp_Basics/UserInput/UserInput.cs
// Run: D:\CGroupProjects\CSharp_Basics>dotnet run --project UserInput

using System;

class UserInput
{
  static void Main(string[] args)
  {
    // Input from user
    Console.Write("Enter username: ");
    string username = Console.ReadLine() ?? "Unknown User";
    // Output
    Console.WriteLine($"Hello {username}");

    // Insert the output into the program.txt file
    System.IO.File.WriteAllText(@"D:\CGroupProjects\CSharp_Basics\UserInput\program.txt", $"Hello {username}");

    // Read the file
    string text = System.IO.File.ReadAllText(@"D:\CGroupProjects\CSharp_Basics\UserInput\program.txt");
    Console.WriteLine(text);
  }
}