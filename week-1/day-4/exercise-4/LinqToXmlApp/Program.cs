
using System;
using System.Linq;
using System.Xml.Linq;
class Program
{
    static void Main(string[] args)
    {
        // Creating XML document representing a collection of books
        XDocument xmlDocument = new XDocument(
            new XElement("Books",
                new XElement("Book",
                    new XElement("Title", "The Alchemist"),
                    new XElement("Author", "Paulo Coelho"),
                    new XElement("Genre", "Fiction")
                ),
                new XElement("Book",
                    new XElement("Title", "To Kill a Mockingbird"),
                    new XElement("Author", "Harper Lee"),
                    new XElement("Genre", "Classics")
                ),
                new XElement("Book",
                    new XElement("Title", "The Great Gatsby"),
                    new XElement("Author", "F. Scott Fitzgerald"),
                    new XElement("Genre", "Classics")
                )
            )
        );
        // Loading XML document and querying for books in a specific genre
        string genre = "Classics";
        var booksInGenre = xmlDocument.Descendants("Book")
                                      .Where(b => b.Element("Genre").Value == genre);
        Console.WriteLine($"Books in the genre '{genre}':");
        foreach (var book in booksInGenre)
        {
            Console.WriteLine($"Title: {book.Element("Title").Value}, Author: {book.Element("Author").Value}");
        }
        Console.WriteLine();
        // Modifying XML document by adding a new book
        XElement newBook = new XElement("Book",
                                new XElement("Title", "Pride and Prejudice"),
                                new XElement("Author", "Jane Austen"),
                                new XElement("Genre", "Classics")
                            );
        xmlDocument.Root.Add(newBook);
        // Modifying XML document by updating existing book information
        XElement existingBook = xmlDocument.Descendants("Book")
                                           .FirstOrDefault(b => b.Element("Title").Value == "The Alchemist");
        if (existingBook != null)
        {
            existingBook.Element("Author").Value = "Paulo Coelho (Updated)";
        }
        Console.WriteLine("Modified XML document:");
        Console.WriteLine(xmlDocument);
    }
}


























