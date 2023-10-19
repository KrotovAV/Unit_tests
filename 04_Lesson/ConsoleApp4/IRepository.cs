using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public interface IRepository
    {
        int GetCount();
        Book GetBook(int index);
        void Add(Book book);
    }
}
