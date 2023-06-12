using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft
{
    internal class Book
    {
        private string title;
        private string author;
        private int pages;

        public Book(string myTitle, string myAuthor, int myPages)
        {
            Title = myTitle;
            Author = myAuthor;
            Pages = myPages;
            Console.WriteLine("Creating a new Book");
        }
        
        public string Title
        { get { return title; }
          set { title = value; } 
        }
        public string Author
        { 
            get { return author; } 
            set { author = value; }
        }
        public int Pages
        { 
            get { return pages; } 
            set { pages = value; }
        }

    }


}
