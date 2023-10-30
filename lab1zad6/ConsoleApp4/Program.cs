namespace ConsoleApp1
{
    class Program
    {
        static void Main()

        {
            int a;
            while (true)
            {
                a = InputInt();
                if (a == 0) break;
            }
        }

        static int InputInt()
        {
            int value = Convert.ToInt32(Console.ReadLine());
            return value;

        }



    }
}