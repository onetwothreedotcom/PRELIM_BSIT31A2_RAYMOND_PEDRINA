namespace WebApp.Models
{
    public class Library
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();
    }
}
