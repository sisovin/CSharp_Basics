/* **********************************
 * IfStatements/IfStatements.cs
 * **********************************/
// Path: D:/CGroupProjects/CSharp_Basics/IfStatements/IfStatements.cs
// Run: D:\CGroupProjects\CSharp_Basics>dotnet run --project IfStatements

using System;

class IfStatements
{
  static void Main(string[] args)
  {

    bool isStudent = false;
    bool isSmart = false;

    if (isStudent && isSmart)
    {
      Console.WriteLine("You are a student");
    }
    else if (isStudent && !isSmart)
    {
      Console.WriteLine("You are not a smart student");
    }
    else
    {
      Console.WriteLine("You are not a student and not smart");
    }

    // >, <, >=, <=, !=, ==
    if (1 < 3)
    {
      Console.WriteLine("number omparison was true");
    }

  }
}
