using System;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            string line;
            line = Console.ReadLine();
            a = int.Parse(line);
            while (a > 0)
            {
                Console.WriteLine(a % 10 + " ");
                a = a / 10;

            }



        }
    }
}
