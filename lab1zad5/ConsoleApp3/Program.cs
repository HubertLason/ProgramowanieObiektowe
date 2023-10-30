namespace ConsoleApp1
{
    class Program
    {
        static void Main()

        {
            Liczby();
        }

        static void Liczby()
        {
            for (int i = 20; i >= 0; i--)
            {
                if (i == 2 | i == 6 | i == 9 | i == 15 | i == 19) continue;
                else Console.WriteLine(i);

            }

        
        
        }


    }
}