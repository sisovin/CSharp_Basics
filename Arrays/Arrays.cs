/* **********************************
 * Arrays/Arrays.cs
 * **********************************/
// Path: D:/CGroupProjects/CSharp_Basics/Arrays/arrays.cs
// Run: D:\CGroupProjects\CSharp_Basics>dotnet run --project Arrays

using System;

class Arrays
{
  static void Main(string[] args)
  {
    // Arrays
    Console.WriteLine("========== Arrays ==========");
    int[] numbers = { 1, 2, 3, 4, 5 };
    Console.WriteLine(numbers.Length);
    Console.WriteLine(numbers[0]);
    Console.WriteLine(numbers[1]);
    Console.WriteLine(numbers[2]);
    Console.WriteLine(numbers[3]);
    Console.WriteLine(numbers[4]);    

    Console.WriteLine("========== Lucky Numbers ==========");
    //int [] luckyNumbers = new int[10];
    int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
    //         indexes:    0  1  2   3   4   5
    luckyNumbers[0] = 90;
    Console.WriteLine(luckyNumbers[0]);
    Console.WriteLine(luckyNumbers[1]);
    Console.WriteLine(luckyNumbers.Length);

  }
}
