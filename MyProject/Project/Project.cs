using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace MyProject.Project
{
    class Book
    {
        int bookid;
        string bookname;
        int price;
        string authorname;
        Book[] book;
        
        public Book()
        {


        }
        public Book(int bookid,string bookname,int price,string authorname)
        {
            this.bookid = bookid;
            this.bookname = bookname;
            this.price = price;
            this.authorname = authorname;

        }

        public void CreateBook(Book []b )
        {
            this.book = b;

        }
        public override string ToString()
        {
            return bookid + " " + bookname + " " + price + " " + authorname;
        }

        public void ShowAllBooks()
        {
            // display all the records from book array

            for(int i=0;i<book.Length;i++)
            {
                if(book[i]!=null)
                {
                    Console.WriteLine(book[i]);
                }
            }
        }

        public void ShowBookById(int id)
        {
            foreach(Book bt in book)
            {
                if(bt != null)
                {
                    if(id == bt.bookid)
                    {
                        Console.WriteLine(bt);

                    }
                }
            }
        }

        public void UpdateBook(int id)
        {
            for(int i = 0;i<book.Length;i++)
            {
                if (id == book[i].bookid && book[i]!=null)
                {
                    Console.WriteLine("Enter price for update");
                    book[i].price = int.Parse(Console.ReadLine());
                }
            }

        }

        public void Deletebook(int id)
        {
            for(int i=0;i<book.Length;i++)
            {
                if (id == book[i].bookid && book[i]!=null)
                {
                    book[i] = null;
                }
            }
        }
    }


    internal class Project
    {
        
        static void Main(string[] args)
        {
            Book[] b = new Book[3];
            
            // logic to book array

            for(int i=0;i<b.Length;i++)
            {
                Console.WriteLine("Enter the bookid ");
                int bid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the bookname ");
                string bname = Console.ReadLine();
                Console.WriteLine("Enter the price ");
                int p = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the author ");
                string aname = Console.ReadLine();

                b[i] = new Book(bid, bname, p, aname);

            }

            Book bk = new Book();
            bk.CreateBook(b);
            bk.ShowAllBooks();
            bk.ShowBookById(100);
            bk.UpdateBook(100);
            bk.ShowAllBooks();
            bk.Deletebook(100);
            bk.ShowAllBooks();
        }

    }
}
