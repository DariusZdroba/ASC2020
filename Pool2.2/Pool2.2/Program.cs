using System;

namespace Pool2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int contorNegativ = 0, contorZero =0 , contorPozitiv = 0;
            int n;
            string line;
            line = Console.ReadLine();
            n = int.Parse(line);
            for(int i = 1; i <= n; i++)
            {
                line = Console.ReadLine();
                int k = int.Parse(line);
                if (k < 0) contorNegativ++;
                else if (k == 0) contorZero++;
                else contorPozitiv++;
            }
            Console.WriteLine(contorNegativ + " negative  " + contorZero + " zero " + contorPozitiv + " pozitive ");
        }
    }
}
