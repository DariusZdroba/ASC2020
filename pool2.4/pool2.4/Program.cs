using System;

namespace pool2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,n;
            int pozitie = -1;
            string line;
            line = Console.ReadLine();
            n = int.Parse(line);
            line = Console.ReadLine();
            a = int.Parse(line);
            for (int i = 0; i < n; i++)
            {
                line = Console.ReadLine();
                int k = int.Parse(line);
                if (k == a) pozitie = i;

            }
            Console.WriteLine("pozitia " + pozitie);
        }
    }
}
