/* **********************************
 * ForLoops/ForLoops.cs
 * **********************************/
// Path: D:/CGroupProjects/CSharp_Basics/ForLoops/ForLoops.cs
// Run: D:\CGroupProjects\CSharp_Basics>dotnet run --project ForLoops

using System;

class ForLoops
{
  static void Main(string[] args)
  {


    for (int i = 0; i < 5; i++)
    {
      Console.WriteLine(i);
    }

    int[] luckyNums = { 4, 8, 15, 16, 23, 42 };
    foreach (int luckyNum in luckyNums)
    {
      Console.WriteLine(luckyNum);
    }


  }
}