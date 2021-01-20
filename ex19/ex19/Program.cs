using System;

namespace ex19
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b = 0, c =0, contor = 0;
            string line;
            line = Console.ReadLine();
            a = int.Parse(line);
            b = a % 10;
            while (a > 9)
            {
                a = a / 10;
                c = a % 10;
                if (c == b) contor++;
            }
            if (contor == 2) Console.WriteLine("da");
            else Console.WriteLine("nu");
        }
    }
}
