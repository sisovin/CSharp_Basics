/***********************************
 * Inheritance
 * **********************************/
// Path: D:/CGroupProjects/CSharp_Basics/Inheritance/Inheritance.cs
// Run: D:\CGroupProjects\CSharp_Basics>dotnet run --project Inheritance

using System;

namespace Inheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      Chef myChef = new Chef("Gordon Ramsay", 50);
      myChef.MakeChicken();

      ItalianChef myItalianChef = new ItalianChef("Massimo Bottura", 55, "Italy");
      myItalianChef.MakeChicken();
      Console.WriteLine(myItalianChef.countryOfOrigin);
    }
  }

  public class Chef
  {
    public String name;
    public int age;

    public Chef(String name, int age)
    {
      this.name = name;
      this.age = age;
    }

    public void MakeChicken()
    {
      Console.WriteLine("The chef makes chicken");
    }

    public void MakeSalad()
    {
      Console.WriteLine("The chef makes salad");
    }

    public virtual void MakeSpecialDish()
    {
      Console.WriteLine("The chef makes a special dish");
    }
  }

  public class ItalianChef : Chef
  {
    public String countryOfOrigin;

    public ItalianChef(String name, int age, String countryOfOrigin)
      : base(name, age)
    {
      this.countryOfOrigin = countryOfOrigin;
    }

    public void MakePasta()
    {
      Console.WriteLine("The Chef makes pasta");
    }

    public override void MakeSpecialDish()
    {
      Console.WriteLine("The chef makes chicken parm");
    }
  }
}