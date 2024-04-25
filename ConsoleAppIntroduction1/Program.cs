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

var book5 = new Book()
{
    Title = "Paper Towns",
    Author = new Author()
    {
        FirstName = "John",
        LastName = "Green",
        Age = 40
    },
    ISBN = 9780062457714,
    Owner = new Owner()
    {
        FirstName = "Isabella",
        LastName = "Torrente"
    },
    Pages = 250,
    PrimaryColor = Color.Yellow,
    SecondaryColor = Color.Black,

};

var book6 = new Book()
{
    Title = "El Codigo Da vinci",
    Author = new Author()
    {
        FirstName = "Dan",
        LastName = "Brown",
        Age = 40
    },
    ISBN = 8495618605,
    Owner = new Owner()
    {
        FirstName = "David",
        LastName = "Nicolaas"
    },
    Pages = 250,
    PrimaryColor = Color.Red,
    SecondaryColor = Color.Yellow,

};

var book7 = new Book()
{
    Title = "the 4 hour work week",
    Author = new Author()
    {
        FirstName = "Tim",
        LastName = "Ferris",
        Age = 40,
        Gender = "Male"
    },
    ISBN = 9780091929114,
    Owner = new Owner()
    {
        FirstName = "Isabella",
        LastName = "Torrente"
    },
    Pages = 250,
    PrimaryColor = Color.Pink,
    SecondaryColor = Color.Beige,
    AudioBookAvailable = true

};



Console.WriteLine($"The author of the Book {book1.Title} is {book1.Author.FirstName} {book1.Author.LastName} and the color of this book is: {book1.PrimaryColor} and {book1.SecondaryColor}. This book has {book1.Pages} Pages, Language:{book1.Language} with ISBN:{book1.ISBN} and is now owned by {book1.Owner.FirstName} {book1.Owner.LastName} ");
Console.WriteLine($"The author of the Book {book2.Title} is {book2.Author.FirstName} {book2.Author.LastName} and the color of this book is: {book2.PrimaryColor} and {book2.SecondaryColor}. This book has {book2.Pages} Pages,  with ISBN:{book2.ISBN} and is now owned by {book2.Owner.FirstName} {book2.Owner.LastName} ");
Console.WriteLine($"The author of the Book {book3.Title} is {book3.Author.FirstName} {book3.Author.LastName} and the color of this book is: {book3.PrimaryColor} and {book3.SecondaryColor}. This book has {book3.Pages} Pages,  with ISBN:{book3.ISBN} and is now owned by {book3.Owner.FirstName} {book3.Owner.LastName} ");
Console.WriteLine($"The author of the Book {book4.Title} is {book4.Author.FirstName}");
Console.WriteLine($"The author of the Book {book5.Title} is {book5.Author.FirstName} {book5.Author.LastName}");
Console.WriteLine($"The author of the Book {book6.Title} is {book6.Author.FirstName} {book6.Author.LastName}");
Console.WriteLine($"The author of the Book {book7.Title} is a {book7.Author.Gender} and it is an AudioBook: {book7.AudioBookAvailable}");