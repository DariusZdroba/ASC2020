using System;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string line;
            line = Console.ReadLine();
            a = int.Parse(line);
            line = Console.ReadLine();
            b = int.Parse(line);
                
            a = a * b;       
            b = a / b;      
            a = a / b;
            Console.WriteLine(a + " " + b);
        }
    }
}
