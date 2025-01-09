/***********************************
 * Abstract Classes and Methods
 * **********************************/
// Path: D:/CGroupProjects/CSharp_Basics/AbstractClassesMethods/AbstractClassesMethods.cs
// Run: D:\CGroupProjects\CSharp_Basics>dotnet run --project AbstractClassesMethods

using System;

namespace AbstractClassesMethods
{
  abstract class Vehicle
  {
    public abstract void move();
    public void getDescription()
    {
      Console.WriteLine("Vehicles are used for transportation");
    }
  }

  class Bicycle : Vehicle
  {
    public override void move()
    {
      Console.WriteLine("The bicycle pedals forward");
    }
  }

  class Plane : Vehicle
  {
    public override void move()
    {
      Console.WriteLine("The plane flies through the sky");
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Vehicle myBicycle = new Bicycle();
      myBicycle.move();
      myBicycle.getDescription();

      Vehicle myPlane = new Plane();
      myPlane.move();
      myPlane.getDescription();
    }
  }
}