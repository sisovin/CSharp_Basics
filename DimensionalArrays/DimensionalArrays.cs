/* **********************************
 * 2 DimensionalArrays/DimensionalArrays.cs
 * **********************************/
// Path: D:/CGroupProjects/CSharp_Basics/DimensionalArrays/DimensionalArrays.cs
// Run: D:\CGroupProjects\CSharp_Basics>dotnet run --project DimensionalArrays

using System;

class DimensionalArrays
{
  static void Main(string[] args)
  {
    // Dimensional Arrays
    Console.WriteLine("========== Example 1: ==========");
    int[,] numbers = new int[2, 3];
    numbers[0, 0] = 1;
    numbers[0, 1] = 2;
    numbers[0, 2] = 3;
    numbers[1, 0] = 4;
    numbers[1, 1] = 5;
    numbers[1, 2] = 6;

    Console.WriteLine(numbers[1, 2]);

    Console.WriteLine("========== Example 2: ==========");

    // int [][] numberGrid = new int[2][3];
    int[][] numberGrid = { new int[] { 1, 2 }, new int[] { 3, 4 } };
    numberGrid[0][1] = 99;

    Console.WriteLine(numberGrid[0][0]);
    Console.WriteLine(numberGrid[0][1]);
  }
}