using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        //Здравствуйте, Леонид! Если Вы чтаете это сообщение, значит я здесь ещё разбираюсь с Mockами 
        {
            Book A = new Book("001", "Aaaaaa", "Aaaa A");
            Book B = new Book("002", "Bbbbbb", "Bbbb B");
            Book C = new Book("003", "Cccccc", "Cccc C");

            A.printBook();
            B.printBook();
            C.printBook();

            Dictionary<String, Book> Books = new Dictionary<String, Book>();
            Books.Add("1", new Book("001", "Book1", "Author1"));
            Books.Add("2", new Book("002", "Book2", "Author2"));

           
        }
    }
}
