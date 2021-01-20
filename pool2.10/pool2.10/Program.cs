using System;

namespace pool2._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, contor = 1, contorMax = 1, k;
            string line;
            line = Console.ReadLine();
            n = int.Parse(line);
            line = Console.ReadLine();
            k = int.Parse(line);
            int aux = k;
            for (int i = 1; i < n; i++)
            {
                line = Console.ReadLine();
                k = int.Parse(line);
                if (aux == k) contor++;
                else
                {
                     if (contor >= contorMax) contorMax = contor;
                    contor = 1;
                }
                aux = k;
            }
            Console.WriteLine(contorMax + " numere consecutive");

        }
    }
}
