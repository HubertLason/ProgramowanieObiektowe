using System;
using System.Reflection.Metadata;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()

        {
     
            double[] a = new double[10];

            for (int i = 0; i < 10; i++)
            {
                a[i] = InputDouble();
            }
            Menu(a);
        }
        static double InputDouble()
        {
            int value = Convert.ToInt32(Console.ReadLine());
            return value;

        }
        static void Pierwszy(double[] a)
        {
            for (int i = 0;i < 10;i++) Console.WriteLine(a[i]);
        }
        static void Ostatni(double[] a)
        {
            for (int i = 9; i >=0; i--) Console.WriteLine(a[i]);
        }
        static void Parzyste(double[] a)
        {
            for (int i = 0; i < 10; i=i+2) Console.WriteLine(a[i]);
        }
        static void Nieparzyste(double[] a)
        {
            for (int i = 1; i < 10; i = i + 2) Console.WriteLine(a[i]);
        }

        static void view()
        {
            Console.WriteLine("=== 1. Wyświetlanie tablicy od pierwszego do ostatniego indeksu \t\t\t ===");
            Console.WriteLine("=== 2. Wyświetlanie tablicy od ostatniego do pierwszego indeksu \t\t\t ===");
            Console.WriteLine("=== 3. Wyświetlanie elementów o nieparzystych indeksach \t\t\t ===");
            Console.WriteLine("=== 4. Wyświetlanie elementów o parzystych indeksach \t\t\t ===");
            Console.WriteLine("=== 5. Wyjście \t\t\t ===");
        }

        static void Menu(double[] a)
        {
            double choice;
            do
            {
                view();
                choice = InputDouble();
                if (choice == 1) Pierwszy(a);
                else if (choice == 2) Ostatni(a);
                else if (choice == 3) Nieparzyste(a);
                else if (choice == 4) Parzyste(a);
            }
            while (choice != 5);

        }


    }
}