using System;

namespace Ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, n, i;
            string line;
            Console.WriteLine("Dati intervalul de ani");
            line = Console.ReadLine();
            a = int.Parse(line);

            line = Console.ReadLine();

            b = int.Parse(line);
           
            if (a < b)
                for (i = a; i <= b; i++)
                    if (i % 4 == 0) Console.WriteLine(i + " ");
                    else if (b < a)
                        for (i = a; i <= b; i++)
                            if (i % 4 == 0) Console.WriteLine(i + " ");
                            else Console.WriteLine("an1=an2");
        }
    }
}
