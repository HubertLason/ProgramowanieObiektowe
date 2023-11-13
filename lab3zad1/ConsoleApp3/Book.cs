using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Book
    {
        private string title;
        private Person author;
        public Book(string title,Person author)
        {
            this.title = title;
            this.author = author;   

        }
        public string Title { get { return title; } set { } }
        public void View() {
            Console.WriteLine("Tytuł książki: "+title);
        }

    }
}
