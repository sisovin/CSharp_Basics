/* **********************************
 * Variables/Variables.cs
 * **********************************/
/*
Names are case-sensitive and may begin with:
    letters, _, @
After, may include
    letters, numbers, _
Convention says
    Start with a lowercase word, then additional words are capitalized
    ex. myFirstVariable
*/
// Path: D:/CGroupProjects/CSharp_Basics/Variables/Variables.cs
// Run: D:\CGroupProjects\CSharp_Basics>dotnet run --project Variables

using System;

class Variables
{
  static void Main(string[] args)
  {
    string name = "Mike";    // String's are objects not primitives
    char testGrade = 'A';    // single 16-bit Unicode character.

    // short, int, long can be pre-pended with 'u' for 'unsigned'
    byte age0 = 0;           // 8-bit unsigned integer
    short age1 = 10;         // 16-bit signed integer.
    int age2 = 20;           // 32-bit signed integer
    long age3 = 30L;         // 64-bit signed integer

    float gpa0 = 2.5F;       // 32-bit floating point
    double gpa1 = 3.5;       // 64-bit double-precision floating point
    decimal gpa2 = 4.5M;     // 128-bit precise decimal

    bool isTall;             // 1 bit -> true/false
    isTall = true;

    name = "John";

    Console.WriteLine("Your name is " + name);
    Console.WriteLine($"Your name is {name}");

    // Use the variables to avoid warnings
    Console.WriteLine($"Test Grade: {testGrade}");
    Console.WriteLine($"Age0: {age0}");
    Console.WriteLine($"Age1: {age1}");
    Console.WriteLine($"Age2: {age2}");
    Console.WriteLine($"Age3: {age3}");
    Console.WriteLine($"GPA0: {gpa0}");
    Console.WriteLine($"GPA1: {gpa1}");
    Console.WriteLine($"GPA2: {gpa2}");
    Console.WriteLine($"Is Tall: {isTall}");
  }
}