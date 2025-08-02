namespace WebApp.Models
{
    public class Availability
    {
        public int? IsAvailable { get; set; }

        public List<Book> Books { get; set; } = new List<Book>();
    }
}
