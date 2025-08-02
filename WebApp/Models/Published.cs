namespace WebApp.Models
{
    public class Published
    {
        public DateTime DatePublised { get; set; }

        public List<Book> Books { get; set; } = new List<Book>();
    }
}
