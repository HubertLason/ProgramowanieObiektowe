using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        public string FirstName { get { return firstName; } set { } }
        public string LastName { get { return lastName; } set { } }
        public int Age { get { return age; } set { } }
        
        public Person(string firstName, string lastname, int age)
        {
            this.firstName = firstName;
            this.lastName = lastname;
            this.age = age;
        }
        public void View() {
            Console.WriteLine("Imię: "+firstName);
            Console.WriteLine("Nazwisko: " + lastName);
            Console.WriteLine("Wiek: " + age);
        }
    }
}
