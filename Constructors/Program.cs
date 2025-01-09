/* **********************************
 * Constructors
 * **********************************/
// Path: D:/CGroupProjects/CSharp_Basics/Constructors/Constructors.cs
// Run: D:\CGroupProjects\CSharp_Basics>dotnet run --project Constructors

using System;

public class Book
{
  public String title;
  public String author;

  public Book(String title, String author)
  {
    this.title = title;
    this.author = author;
  }

  public void readBook()
  {
    Console.WriteLine("Reading " + this.title + " by " + this.author);
  }
}

public class Program
{
  public static void Main(string[] args)
  {
    ReadBook();
  }

  public static void ReadBook()
  {
    Book book1 = new Book("Harry Potter", "JK Rowling");
    Console.WriteLine(book1.title);

    Book book2 = new Book("Lord of the Rings", "JRR Tolkien");
    Console.WriteLine(book2.title);
  }
}