namespace WebApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }

        public List<Borrow> BorrowedBooks { get; set; } = new List<Borrow>();


    }
}
