// See https://aka.ms/new-console-template for more information
using Programming.Lessons.Entities;

Console.WriteLine("Hello, World!");

var book1 = new Book()
{
    Title = "The Code of the Extraordinary Mind",
    Author = new Author()
    {
        FirstName = "Vishen",
        LastName = "Lakhiani",
        Age = 48
    },
    ISBN = 9781623367589,
    Owner = new Owner()
    {
        FirstName = "A.",
        LastName = "W."
    },
    Pages = 250,
    PrimaryColor = Color.White,
    SecondaryColor = Color.Gold,
    PublicationYear = 2016,
    Language = "English"
    
};


var book2 = new Book()
{
    Title = "Think and Grow Rich",
    Author = new Author()
    {
        FirstName = "Napoleon",
        LastName = "Hill",
        Age = 348
    },
    ISBN = 9781932429237,
    Owner = new Owner()
    {
        FirstName = "A.",
        LastName = "W."
    },
    Pages = 254,
    PrimaryColor = Color.Green,
    SecondaryColor = Color.DarkGreen,
   
    
};



var book3 = new Book()
{
    Title = "The Power",
    Author = new Author()
    {
        FirstName = "Rhonda",
        LastName = "Byrne",
        Age = 73
    },
    ISBN = 978143918178,
    Owner = new Owner()
    {
        FirstName = "D.",
        LastName = "N."
    },
    Pages = 250,
    PrimaryColor = Color.Red,
    SecondaryColor = Color.Yellow,
   
};


var book4 = new Book()
{
    Title = "The Subtle Art of Not Giving a F*ck: A Counterintuitive Approach to Living a Good Life",
    Author = new Author()
    {
        FirstName = "Mark",
        LastName = "Manson",
        Age = 40
    },
    ISBN = 9780062457714,
    Owner = new Owner()
    {
        FirstName = "D.",
        LastName = "N."
    },
    Pages = 250,
    PrimaryColor = Color.Orange,
    SecondaryColor = Color.Black,

};



Console.WriteLine($"The author of the Book {book1.Title} is {book1.Author.FirstName} {book1.Author.LastName} and the color of this book is: {book1.PrimaryColor} and {book1.SecondaryColor}. This book has {book1.Pages} Pages, Language:{book1.Language} with ISBN:{book1.ISBN} and is now owned by {book1.Owner.FirstName} {book1.Owner.LastName} ");
Console.WriteLine($"The author of the Book {book2.Title} is {book2.Author.FirstName} {book2.Author.LastName} and the color of this book is: {book2.PrimaryColor} and {book2.SecondaryColor}. This book has {book2.Pages} Pages,  with ISBN:{book2.ISBN} and is now owned by {book2.Owner.FirstName} {book2.Owner.LastName} ");
Console.WriteLine($"The author of the Book {book3.Title} is {book3.Author.FirstName} {book3.Author.LastName} and the color of this book is: {book3.PrimaryColor} and {book3.SecondaryColor}. This book has {book3.Pages} Pages,  with ISBN:{book3.ISBN} and is now owned by {book3.Owner.FirstName} {book3.Owner.LastName} ");
Console.WriteLine($"The author of the Book {book4.Title} is {book4.Author.FirstName}");