using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleLogin.Models
{
    public class Author
    {
        public Author()
        {
            this.Books = new List<Book>();
        }

        public int AuthorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public virtual List<Book> Books { get; set; }
    }

    public class Book
    {
        public int BookID { get; set; }
        public int AuthorID { get; set; }
        public int CategoryID { get; set; }
        public string Title { get; set; }
        public DateTime PublicationDate { get; set; }
        public string ISBN { get; set; }
        public string CoverImage { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Publisher { get; set; }
        public string NoTransaksi { get; set; }

        public virtual Author Author { get; set; }
        public virtual Category Category { get; set; }
    }

    public class Category
    {
        public Category()
        {
            this.Books = new List<Book>();
        }

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public virtual List<Book> Books { get; set; }
    }

}