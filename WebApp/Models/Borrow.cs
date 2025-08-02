namespace WebApp.Models
{
        public class Borrow
        {
            public Book Book { get; set; }
            public DateTime DateBorrowed { get; set; }
            public DateTime? DateReturned { get; set; }  // nullable, null if not returned yet
        }
    }

