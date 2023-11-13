using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace ConsoleApp3
{
    class Reader:Person
    {
        Book[] Books;
        public Reader(string firstName,string lastName, int age, Book[] book): base(firstName,lastName,age)
        {
            this.Books = book;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
        public void ViewBook() {
            Console.WriteLine("Tytuły:");
            for (int i = 0; i < Books.Length; i++)
            {
                Books[i].View();
            }
        
        }
        public void View() {
            Console.WriteLine("Imię: " + FirstName);
            Console.WriteLine("Nazwisko: " + LastName);
            ViewBook();




        }

    }
}
