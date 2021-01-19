using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;   string line;
            Console.WriteLine("Dati 2 numere : ");
            line = Console.ReadLine();
            n = int.Parse(line);
            line = Console.ReadLine();
            k = int.Parse(line);
            if (n % k == 0) Console.WriteLine("Se divide ");
            else Console.WriteLine("Nu se divide");
        }
    }
}
