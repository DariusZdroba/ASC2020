using System;

namespace pool2._11
{
    class Program
    {
       static int invers(int k)
        {
            int invers = 0;
            while (k > 0)
            {
                invers = invers * 10 + k % 10;
                k = k / 10;
                }
            return invers;

        }
        static void Main(string[] args)
        {
            string line;
            int n,k,suma=0;
            line = Console.ReadLine();
            n = int.Parse(line);
            for (int i = 1; i <= n; i++) {
                line = Console.ReadLine();
                k = int.Parse(line);

                suma = suma + invers(k);
                    
                    
                    }

            Console.WriteLine(suma);



        }
    }
}
