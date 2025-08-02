namespace WebApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public Author Author { get; set; }
        public Genre Genre { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime DatePublished { get; set; }
    }

}
