using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            string line;
            Console.WriteLine("Dati 3 numere pentru a verifica daca se poate forma un triunghi cu lungimile laturilor");
            line = Console.ReadLine();
            a = int.Parse(line);
            line = Console.ReadLine();
            b = int.Parse(line);
            line = Console.ReadLine();
            c = int.Parse(line);
            if (((a > 0) && (b > 0) && (c > 0)) && ((a + b > c) || (a + c > b) || (b + c > a))) Console.WriteLine("Se poate forma");
            else Console.WriteLine("Nu se poate forma");
        }
    }
}
