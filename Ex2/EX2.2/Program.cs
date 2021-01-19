using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0.0f;
            double b = 0.0f;
            double c = 0.0f;

            string line;
            Console.WriteLine("Dati 3 numere a,b,c pentru a forma ecuatia de gradul 2 ax^2 +bx + c");
            line = Console.ReadLine();
            a = double.Parse(line);

            line = Console.ReadLine();
            b = double.Parse(line);

            line = Console.ReadLine();
            c = double.Parse(line);

            double delta = Math.Sqrt(b * b - 4 * a * c);
            b = 0 - b;
            Console.Write("x1= " + (b + delta) / 2 * a);
            Console.WriteLine("  x2= " + (b - delta) / 2 * a);


        }
    }
}
