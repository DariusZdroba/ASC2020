using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b; string line;
            line = Console.ReadLine();
            a = int.Parse(line);

            line = Console.ReadLine();
            b = int.Parse(line);
            int c = b;
            b = a;
            a = c;
            Console.WriteLine(a + " " + b);
            

        }
    }
}
