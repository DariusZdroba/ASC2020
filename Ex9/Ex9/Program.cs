using System;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string line;
            line = Console.ReadLine();
            n = int.Parse(line);
            for (int i = 2; i < n / 2; i++)
                if (n % i == 0) Console.WriteLine(i + " ");


        }
    }
}
