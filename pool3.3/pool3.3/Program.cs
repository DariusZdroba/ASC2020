using System;

namespace pool3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,nrMax,nrMin;
            string line;
            line = Console.ReadLine();
            n = int.Parse(line);
            int[] v = new int[n];
            line = Console.ReadLine();
            v[0] = int.Parse(line);
            nrMax = v[0];
            nrMin = v[0];
          
            for (int i = 1; i < n; i++) {
                line = Console.ReadLine();
                v[i] = int.Parse(line);
                if (v[i] > nrMax) nrMax = v[i];
                if (v[i] < nrMin) nrMin = v[i];
            }

            Console.WriteLine("Minim = " + nrMin + " Maxim = " + nrMax);


        }
    }
}
