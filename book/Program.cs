using System;
using System.Collections.Generic;


Book book1 = new Book() {
    Author = "J. R. R. Tolkien",
    Title = "The Fellowship of the Ring"
};

Book book2 = new Book() {
    Author = "J. R. R. Tolkien",
    Title = "The Two Towers"
};

Book book3 = new Book() {
    Author = "J. R. R. Tolkien",
    Title = "The Return of the King"
};

List<Book> myLibrary = new List<Book>();

myLibrary.AddRange(new List<Book>(){
    book1,
    book2,
    book3
});

foreach(Book book in myLibrary)
{
    Console.WriteLine($"{book.Title} by {book.Author}");
}

class Book
{
    public string Author { get; set; }
    public string Title { get; set; }
}