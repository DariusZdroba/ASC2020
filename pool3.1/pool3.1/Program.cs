using System;

namespace pool3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxim, suma = 0 ; 
           
            
            string line;
            line = Console.ReadLine();
            maxim = int.Parse(line);
            int[] v = new int[maxim];
            for (int i = 0; i < maxim; i++)
            {
                line = Console.ReadLine();
                v[i] = int.Parse(line);
                suma = suma + v[i];
            }
            Console.WriteLine(suma);
        }
    }
}
