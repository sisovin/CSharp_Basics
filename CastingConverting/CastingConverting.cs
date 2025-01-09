/* **********************************
 * CastingConverting/CastingConverting.cs
 * **********************************/
// Path: D:/CGroupProjects/CSharp_Basics/CastingConverting/CastingConverting.cs
// Run: D:\CGroupProjects\CSharp_Basics>dotnet run --project CastingConverting

using System;

class CastingConverting
{
  static void Main(string[] args)
  {
    // Implicit Casting
    int myInt = 9;
    double myDouble = myInt; // Automatic casting: int to double
    
    Console.WriteLine((int)3.14);
    Console.WriteLine((double)3);

    int intFromString = Convert.ToInt32("50");
    double doubleFromString = Convert.ToDouble("50.99");

    Console.WriteLine(100 + intFromString);
    Console.WriteLine(100 + doubleFromString);

  }
}

