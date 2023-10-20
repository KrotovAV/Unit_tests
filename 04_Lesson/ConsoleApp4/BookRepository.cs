using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public interface BookRepository
    {
        Book findById(String Id);
        List<Book> findAll();

    }
}
