using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class BookService
    {
        private BookRepository bookRepository;

        public BookService(BookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public Book findBookById(String Id)
        {
            return bookRepository.findById(Id);
        }

        public List<Book> findAllBooks()
        {
            return bookRepository.findAll();
        }
    }
}
