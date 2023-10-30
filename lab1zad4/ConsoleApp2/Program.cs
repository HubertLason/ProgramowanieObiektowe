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
           
            Console.WriteLine(Suma(a));
            Ilooczyn(a);
            Srednia(a);
            Maximum(a);
            Minimum(a);
        }
        static double InputDouble()
        {
            Console.WriteLine("Podaj liczbe");
            double value = Convert.ToDouble(Console.ReadLine());
            return value;

        }
        static double Suma(double[] a)
        {
            double b = 0;
            for (int i = 0; i < 10; i++) b=b+a[i];
            return b;
        }
        static void Ilooczyn(double[] a)
        {
            double b = a[0];
            for (int i = 1; i < 10; i++) b = b * a[i];
            Console.WriteLine(b);
        }
        static void Srednia(double[] a)
        {
            Console.WriteLine(Suma(a)/10);
        }
        static void Maximum(double[] a)
        {
            Console.WriteLine(a.Max());
        }
        static void Minimum(double[] a)
        {
            Console.WriteLine(a.Min());
        }



    }
}