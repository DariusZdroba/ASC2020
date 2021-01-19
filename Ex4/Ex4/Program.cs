using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n ; string line;
            Console.WriteLine("Dati un an: ");
            line = Console.ReadLine();
            n = int.Parse(line);
           
            if (n % 4 == 0) Console.WriteLine("an bisect ");
            else Console.WriteLine("nu e an bisect");
        }
    }
}
