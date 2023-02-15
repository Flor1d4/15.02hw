using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[]
            {
             new Book(223,"Harry Potter 1"),
             new Book(636,"Harry Potter 4"),
             new Book(317,"Harry Potter 3"),
             new Book(251,"Harry Potter 2")
            };
            Console.WriteLine("-Before Sorting Books-");
            foreach(Book book in books)
            {
                Console.WriteLine("Pages - {0}, Book name - {1}",book.Pages,book.Name);
            }
            Array.Sort(books);
            Console.WriteLine();
            Console.WriteLine("-After Sorting-");
            foreach(Book book in books) 
            {
                Console.WriteLine("Pages - {0}, Book name - {1}", book.Pages, book.Name);
            }

            Book bookOne = new Book(223, "Harry Potter 1");
            Book bookTwo = new Book(251, "Harry Potter 2");
            Book bookTree = new Book(317, "Harry Potter 3");
            Book bookFour = new Book(636, "Harry Potter 4");
            Console.WriteLine("\n-Cloning-");
            Console.WriteLine("Pages - {0}, Book name - {0}", bookOne);
            Console.WriteLine("Pages - {0}, Book name - {0}", bookTwo);
            Console.WriteLine("Pages - {0}, Book name - {0}", bookTree);
            Console.WriteLine("Pages - {0}, Book name - {0}", bookFour);
        }
    }
    public class Book : IComparable,ICloneable
    {
        public int Pages;
        public string Name;
        public Book(int pages, string name)
        {
            this.Name=name;
            this.Pages=pages;
        }
        public int CompareTo(object incomingobject)
        {
            Book incomingbook= incomingobject as Book;
            return this.Pages.CompareTo(incomingbook.Pages);
        }
        //public string Name { get; set; }
        public Book(int v)
        {
        }
        public Book(Book other)
        {
            this.Pages = other.Pages;
            this.Name = other.Name;
        }
        public Book Clone() { return new Book(this); }
        object ICloneable.Clone()
        {
            return Clone();
        }
        public override string ToString()
        {
            return string.Format("Pages - {0}, Book name - {1}", this.Pages, this.Name);
        }

    }
  
    //internal class Book : ICloneable
    //{
    //    //public int Pages { get; set; }
    //    //public string Name { get; set; }

    //    //public Book(int pages, string name)
    //    //{
    //    //    this.Pages = pages;
    //    //    this.Name = name;
    //    //}
       
    //}


}

