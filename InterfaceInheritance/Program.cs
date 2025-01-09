/***********************************
 * Interface Inheritance
 * **********************************/
// Path: D:/CGroupProjects/CSharp_Basics/InterfaceInheritance/InterfaceInheritance.cs
// Run: D:\CGroupProjects\CSharp_Basics>dotnet run --project InterfaceInheritance

using System;

namespace InterfaceInheritance
{
  public interface Animal
  {
    void Speak();
    void Eat();
  }

  public class Dog : Animal
  {
    public void Speak()
    {
      Console.WriteLine("Woof Woof");
    }

    public void Eat()
    {
      Console.WriteLine("Dog is eating");
    }
  }

  public class Cat : Animal
  {
    public void Speak()
    {
      Console.WriteLine("Meow Meow");
    }

    public void Eat()
    {
      Console.WriteLine("Cat is eating");
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Animal[] animals = {
                new Dog(),
                new Cat()
            };

      foreach (Animal animal in animals)
      {
        animal.Speak();
        animal.Eat();
      }
    }
  }
}