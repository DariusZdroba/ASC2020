using System;

namespace pool2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0, produs = 1, n;
            string line;
            line = Console.ReadLine();
            n = int.Parse(line);
            for(int i = 1; i <= n; i++)
            {
                suma = suma + i;
                produs = produs * i;
            }
            Console.WriteLine("produs = " + produs + " suma = " + suma);

        }
    }
}
