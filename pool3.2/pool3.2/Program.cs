using System;

namespace pool3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            int i,n, numar;
            Console.WriteLine("dati numarul n= ");
            line = Console.ReadLine();
            n = int.Parse(line);
            Console.WriteLine("Dati cele n elemente din vector ");
            int[] v = new int[n+1];
            for(i = 1;i<=n;i++)
            {
                line = Console.ReadLine();
                v[i] = int.Parse(line);


            }
            Console.WriteLine("dati numarul dorit de aflat in vector ");
            line = Console.ReadLine();
            numar = int.Parse(line);
            i = 1;
            bool k = true;
            while ((i <= n) && (k))
            {
                if(v[i]==numar)
                {
                    k = false;
                    Console.WriteLine(i-1);
                }
                i++;
            }

        }
    }
}
