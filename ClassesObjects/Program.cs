/* **********************************
 * Classes and Objects
 * **********************************/
// Path: D:/CGroupProjects/CSharp_Basics/ClassesObjects/ClassesObjects.cs
// Run: D:\CGroupProjects\CSharp_Basics>dotnet run --project ClassesObjects

using System;

public class Book
{
  public string? title;
  public string? author;
  public static string staticAttribute = "My Static Attribute";

  public void ReadBook()
  {
    Console.WriteLine($"Reading {this.title} by {this.author}");
  }
}

class ClassesObjects
{
  static void Main(string[] args)
  {
    Book book1 = new Book();
    book1.title = "Harry Potter";
    book1.author = "JK Rowling";

    book1.ReadBook();
    Console.WriteLine(book1.title);

    Book book2 = new Book();
    book2.title = "Lord of the Rings";
    book2.author = "JRR Tolkien";

    book2.ReadBook();
    Console.WriteLine(book2.title);
    Console.WriteLine(Book.staticAttribute);
  }
}