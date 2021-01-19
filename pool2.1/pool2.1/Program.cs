using System;

namespace pool2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, numar;
            string line;
            line = Console.ReadLine();
            n = int.Parse(line);
            for(int i = 1; i <= n; i++)
            {
                line = Console.ReadLine();
                numar = int.Parse(line);
                if (numar % 2 == 0) Console.WriteLine("numar par ");

            }


        }
    }
}
