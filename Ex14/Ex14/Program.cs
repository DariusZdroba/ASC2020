using System;

namespace Ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            int a , c=0;
            string linge;
            linge = Console.ReadLine();
            a = int.Parse(linge);
            int aux = a;
            while (a != 0)
            {
                c = c * 10 + a % 10;
                a = a / 10;

            }
            if (c == aux) Console.WriteLine("palindrom");
            else Console.WriteLine("nu e palindrom");
        }
    }
}
