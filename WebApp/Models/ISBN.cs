namespace WebApp.Models
{
    public class ISBN
    {
        public string num { get; set; }

        public List<Book> Books { get; set; } = new List<Book>();
    }
}
