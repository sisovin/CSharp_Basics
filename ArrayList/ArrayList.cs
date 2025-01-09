/* **********************************
*ArrayList/ArrayListExample.cs
* **********************************/
// Path: D:/CGroupProjects/CSharp_Basics/ArrayList/ArrayListExample.cs
// Run: D:\CGroupProjects\CSharp_Basics>dotnet run --project ArrayList

using System;
using System.Collections;

class ArrayListExample
{
  static void Main(string[] args)
  {
    // ArrayList
    Console.WriteLine("========== Example 1: ==========");
    ArrayList numbers = new ArrayList();
    numbers.Add(1);
    numbers.Add(2);
    numbers.Add(3);
    numbers.Add(4);
    numbers.Add(5);

    numbers.Remove(5);

    foreach (int number in numbers)
    {
      Console.WriteLine(number);
    }

    Console.WriteLine("========== Example 2: ==========");

    ArrayList numberGrid = new ArrayList();
    numberGrid.Add(new ArrayList());
    numberGrid.Add(new ArrayList());

    if (numberGrid[0] is ArrayList row0)
    {
      row0.Add(1);
      row0.Add(2);
      row0.Add(3);
    }

    if (numberGrid[1] is ArrayList row1)
    {
      row1.Add(4);
      row1.Add(5);
      row1.Add(6);
    }

    if (numberGrid[1] is ArrayList row)
    {
      Console.WriteLine(row[2]);
    }

    Console.WriteLine("========== Example 3: ==========");

    ArrayList friends = new ArrayList();
    friends.Add("Oscar");
    friends.Add("Angela");
    friends.Add("Kevin");

    //friends.Remove("Oscar");
    Console.WriteLine(friends[0]);
    Console.WriteLine(friends[1]);
    Console.WriteLine(friends.Contains("Oscar"));
    Console.WriteLine(friends.Count);
  }
}