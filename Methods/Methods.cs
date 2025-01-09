/* **********************************
* Methods/Methods.cs
* **********************************/
// Path: D:/CGroupProjects/CSharp_Basics/Methods/Methods.cs
// Run: D:\CGroupProjects\CSharp_Basics>dotnet run --project Methods

using System;

class Methods
{
  public static void Main(string[] args)
  {
    // Methods
    Console.WriteLine("========== Example 1: ==========");
    int sum = AddNumbers();
    Console.WriteLine(sum);

    Console.WriteLine("========== Example 2: ==========");
    SayHi();
  }

  public static int AddNumbers()
  {
    // Input Number
    Console.Write("Enter Number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter Number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    return num1 + num2;
  }

  public static void SayHi()
  {
    // Input from user
    Console.Write("Enter username: ");
    string username = Console.ReadLine() ?? "Unknown User";
    // Output
    Console.WriteLine($"Hello {username}");
  }
}