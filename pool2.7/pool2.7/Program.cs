using System;

namespace pool2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,k;
            string line;
            line = Console.ReadLine();
            n = int.Parse(line);
            line = Console.ReadLine();
            k = int.Parse(line);
            int maxim = k;
            int minim = k;
            for ( int i = 0; i < n-1; i++)
            {
                line = Console.ReadLine();
                 k = int.Parse(line);
                if (k > maxim) maxim = k;
                if (minim > k) minim = k;
            }

            Console.WriteLine("minimul = " + minim + " maximul = " + maxim);
        }
    }
}
