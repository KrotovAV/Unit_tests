using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp4
{
    public class InMemoryBookRepository : BookRepository
    {
        private Dictionary<String, Book> Books;

        public InMemoryBookRepository()
        {
            this.Books = new Dictionary<String, Book>();
            Books.Add("1", new Book("001", "Book1", "Author1"));
            Books.Add("2", new Book("002", "Book2", "Author2"));
        }


        public Book findById(String Id)
        {
            return Books[Id];
        }

        public List<Book> findAll()
        {
            return Books.Values.ToList();
        }
    }
}
