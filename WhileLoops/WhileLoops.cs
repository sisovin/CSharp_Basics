/* **********************************
 * WhileLoops/WhileLoops.cs
 * **********************************/
// Path: D:/CGroupProjects/CSharp_Basics/ WhileLoops/WhileLoops.cs
// Run: D:\CGroupProjects\CSharp_Basics>dotnet run --project WhileLoops

using System;

class WhileLoops
{
  static void Main(string[] args)
  {

    int index = 1;
    while (index <= 5)
    {
      Console.WriteLine(index);
      index++;
    }

    do
    {
      Console.WriteLine(index);
      index++;
    } while (index <= 5);

  }
}