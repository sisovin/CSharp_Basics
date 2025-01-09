/* **********************************
 * Strings/Strings.cs
 * **********************************/
 // Path: D:/CGroupProjects/CSharp_Basics/Strings/Strings.cs
// Run: D:\CGroupProjects\CSharp_Basics>dotnet run --project Strings

using System;

class Strings
{
  static void Main(string[] args)
  {

    string greeting = "Hello";
    //      indexes:   01234

    Console.WriteLine(greeting.Length);
    Console.WriteLine(greeting[0]);
    Console.WriteLine(greeting.IndexOf("llo"));
    Console.WriteLine(greeting.IndexOf("z"));
    Console.WriteLine(greeting.Substring(2));
    Console.WriteLine(greeting.Substring(1, 3));
  }
}

