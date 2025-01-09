/* **********************************
 * Numbers/Numbers.cs
 * **********************************/
// Path: D:/CGroupProjects/CSharp_Basics/Numbers/Numbers.cs
// Run: D:\CGroupProjects\CSharp_Basics>dotnet run --project Numbers
// Run: D:\CGroupProjects\CSharp_Basics> ./Numbers/bin/Debug/net9.0/Numbers.exe

using System;

class Numbers
{
  static void Main(string[] args)
  {
    int a = 18;
    int b = 6;
    int c = a + b;
    Console.WriteLine(c);
    Console.WriteLine(a - b);
    Console.WriteLine(a * b);
    Console.WriteLine(a / b);
    Console.WriteLine(a % b);

    Console.WriteLine(2 * 3);      // Basic Arithmetic: +, -, /, *
    Console.WriteLine(10 % 3);      // Modulus Op. : returns remainder of 10/3
    Console.WriteLine(1 + 2 * 3);   // order of operations
    Console.WriteLine(10 / 3.0);      // int's and doubles


    int num = 10;
    num += 100; // +=, -=, /=, *=
    Console.WriteLine(num);

    num++;
    Console.WriteLine(num);

    Console.WriteLine(Math.Pow(2, 3));
    Console.WriteLine(Math.Sqrt(144));
    Console.WriteLine(Math.Round(2.7));
  }
}
