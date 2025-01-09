```cs
/***********************************
 * Getters and Setters
 * **********************************/
// Path: D:/CGroupProjects/CSharp_Basics/GettersSetters/GettersSetters.cs
// Run: D:\CGroupProjects\CSharp_Basics>dotnet run --project GettersSetters

using System;

public class Book
{
  private String title = string.Empty;
  private String author = string.Empty;

  public Book(String title, String author)
  {
    this.setTitle(title);
    this.setAuthor(author);
  }

  public String getTitle()
  {
    return this.title;
  }
  public void setTitle(String title)
  {
    this.title = title;
  }

  public String getAuthor()
  {
    return this.author;
  }
  public void setAuthor(String author)
  {
    this.author = author;
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
    Console.WriteLine(book1.getTitle());

    Book book2 = new Book("Lord of the Rings", "JRR Tolkien");
    Console.WriteLine(book2.getTitle());
  }
}
```