/* **********************************
 * SwitchStatements/SwitchStatements.cs
 * **********************************/
// Path: D:/CGroupProjects/CSharp_Basics/SwitchStatements/SwitchStatements.cs
// Run: D:\CGroupProjects\CSharp_Basics>dotnet run --project SwitchStatements

using System;

class SwitchStatements
{
  static void Main(string[] args)
  {

    char myGrade = 'A';
    switch (myGrade)
    {
      case 'A':
        Console.WriteLine("You Pass");
        break;
      case 'F':
        Console.WriteLine("You fail");
        break;
      default:
        Console.WriteLine("Invalid grade");
        break; // Add break statement here
    }
  }
}