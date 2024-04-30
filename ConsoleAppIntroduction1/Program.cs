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
        Age = 48,
        
    },
    AuthorBio = new AuthorBio()
    { Biography = "Vishen Lakhiani (born 14 January 1976) is a Malaysian entrepreneur, author, and motivational speaker, of Indian descent. He is the founder" +
    " and CEO of Mindvalley and the author of two books: The Code of the Extraordinary Mind and The Buddha and the Badass." },
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
    AudioBookAvailable = true,
    BookInfo = new BookInfo()
    {
        Summary = "The 4-Hour Workweek: Escape 9-5, Live Anywhere, and Join the New Rich is a self-help book by Timothy Ferriss, an American writer, educational activist, and entrepreneur. The book has spent more than four years on The New York Times Best Seller List, has been translated into 35 languages and has sold more than 1,350,000 copies worldwide. It deals with what Ferriss refers to as \"lifestyle design\" and repudiates the traditional \"deferred\" life plan in which people work grueling hours and take few vacations for decades and save money in order to relax after retirement."

    },
    BookGenre = Genre.Action,
};

var book8 = new Book()
    {
        Title = "I Am Number Four",
        Author = new Author()
        {
            FirstName = "Pittacus",
            LastName = "Lore",
            Age = 40
        },
        ISBN = 0061969559,
        Owner = new Owner()
        {
            FirstName = "David",
            LastName = "Nicolaas"
        },
        Pages = 250,
        PrimaryColor = Color.Red,
        SecondaryColor = Color.Yellow,
    };




Console.WriteLine($"The author of the Book {book1.Title} is {book1.Author.FirstName} {book1.Author.LastName} and the color of this book is: {book1.PrimaryColor} and {book1.SecondaryColor}. This book has {book1.Pages} Pages, Language:{book1.Language} with ISBN:{book1.ISBN} and is now owned by {book1.Owner.FirstName} {book1.Owner.LastName}. Author Biography: {book1.AuthorBio.Biography} ");
Console.WriteLine($"The author of the Book {book2.Title} is {book2.Author.FirstName} {book2.Author.LastName} and the color of this book is: {book2.PrimaryColor} and {book2.SecondaryColor}. This book has {book2.Pages} Pages,  with ISBN:{book2.ISBN} and is now owned by {book2.Owner.FirstName} {book2.Owner.LastName} ");
Console.WriteLine($"The author of the Book {book3.Title} is {book3.Author.FirstName} {book3.Author.LastName} and the color of this book is: {book3.PrimaryColor} and {book3.SecondaryColor}. This book has {book3.Pages} Pages,  with ISBN:{book3.ISBN} and is now owned by {book3.Owner.FirstName} {book3.Owner.LastName} ");
Console.WriteLine($"The author of the Book {book4.Title} is {book4.Author.FirstName} {book4.Author.LastName}");
Console.WriteLine($"The author of the Book {book5.Title} is {book5.Author.FirstName} {book5.Author.LastName}");
Console.WriteLine($"The author of the Book {book6.Title} is {book6.Author.FirstName} {book6.Author.LastName}");
Console.WriteLine($"The author of the Book {book7.Title} is a {book7.Author.Gender} and it is an AudioBook: {book7.AudioBookAvailable} with Genre {book7.BookGenre}. Summary: {book7.BookInfo.Summary}");
Console.WriteLine($"The author of the Book {book8.Title} is {book8.Author.FirstName} {book8.Author.LastName}");

