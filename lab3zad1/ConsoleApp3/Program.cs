using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Janusz","Kowalski",21);
            Person person2 = new Person("Kamil", "Malinowski", 32);
            Person person3 = new Person("Jan", "Nowak", 25);
            Book book1 = new Book("Krzyżacy",person1);
            Book book2 = new Book("Potop",person2);
            Book book3 = new Book("Pan Tadeusz",person3);
            Book[] tablica = { book1, book2, book3 };
            Reader reader1 = new Reader("Adam", "Dykas", 57, tablica );
            reader1.View();

            reader1.ViewBook();



        }
    }
}
