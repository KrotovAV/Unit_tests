using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Book
    {
        private string Id;
        private string Title;
        private string Author;
        //public string Name;
        //public int Price;

        public Book(){}
        public Book(string id)
        {
            this.Id = id;
        }

        public Book(String id, String title, String author)
        {
            this.Id = id;
            this.Title = title;
            this.Author = author;
        }

        public String getId()
        {
            return Id;
        }

        public void setId(String id)
        {
            this.Id = id;
        }

        public String getTitle()
        {
            return Title;
        }

        public void setTitle(String title)
        {
            this.Title = title;
        }
        public String getAuthor()
        {
            return Author;
        }

        public void setAuthor(String author)
        {
            this.Author = author;
        }

        public void printBook()
        {
            Console.WriteLine($"id: {Id}, Title: {Title}, Author: {Author}");
        }
    }

   
}
