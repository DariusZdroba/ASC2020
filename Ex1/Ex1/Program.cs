using System;

namespace pool1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 0.0f;
            float b = 0.0f;
            Console.WriteLine("Dati doua numere pentru a forma o ecuatie de gradul I de forma ax+b");
            Console.WriteLine();
            Console.WriteLine("a= ");
            string line = Console.ReadLine();
            a = float.Parse(line);
            Console.WriteLine("b=");
            string line2 = Console.ReadLine();
            b = float.Parse(line2);
            Console.WriteLine("Rezultatul ecuatiei este ");
            b = 0 - b;
            float s = b / a;
            Console.Write(s);


        }
    }
}
