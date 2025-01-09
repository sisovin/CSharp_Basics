/* **********************************
 * Exception Catching
 * **********************************/
// Path: D:/CGroupProjects/CSharp_Basics/ExceptionHandler/ExceptionHandler.cs
// Run: D:\CGroupProjects\CSharp_Basics>dotnet run --project ExceptionHandler

using System;

class ExceptionHandler
{
  static void Main(string[] args)
  {
    try
    {
      int[] arr = new int[5];
      arr[6] = 10;
    }
    catch (Exception e)
    {
      Console.WriteLine("Exception: " + e.Message);
    }
    finally
    {
      Console.WriteLine("Finally block executed");
    }        
  }
}