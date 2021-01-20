using System;

namespace pool2._8
{
    class Program
    {
      static int fib(int k)
        { if (k == 0) return 0;
            if (k == 1) return 1;
            if (k == 2) return 1;
            if (k == 3) return 2;
            return fib(k-1) + fib(k - 2);


        }
        static void Main(string[] args)
        {
            int n;
            string line;
            Console.WriteLine("Dati numarul n = ");
            line = Console.ReadLine();
            n = int.Parse(line);
            Console.WriteLine("Al " + n + "-lea termen din sirul lui Fibonacci este " + fib(n));


        }
    }
}
