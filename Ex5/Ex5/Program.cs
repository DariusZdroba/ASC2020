using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            string line; int n, k, c=0;
            Console.WriteLine("Dati un numar n ");

            line = Console.ReadLine();
            n = int.Parse(line);
            Console.WriteLine("Dati un numar al catelea sa fie extras");
            line = Console.ReadLine();
            k = int.Parse(line);

            for (int i = 0; i < k; i++) {
                if (n > 9)
                {
                    c = n % 10;
                    n = n / 10;
                }
                else {
                    Console.WriteLine("Numarul nu are " + k + " cifre");
                    break;
                };
            }
            Console.WriteLine("a " + k + " cifra este ");
            Console.WriteLine(c);

        }
    }
}
