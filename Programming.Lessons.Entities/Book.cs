
namespace Programming.Lessons.Entities
{
    public class Book
    {
        public string? Title { get; set; }
        public int Pages { get; set; }
        public Color PrimaryColor { get; set; }
        public Color SecondaryColor { get; set; }
        public Author Author { get; set; }
        public Owner Owner { get; set; }
        public long ISBN { get; set; }
        public int PublicationYear { get; set; }
        public string Language  { get; set;}
        public bool AudioBookAvailable { get; set; }
        public BookInfo BookInfo { get; set; }

        }
    }
