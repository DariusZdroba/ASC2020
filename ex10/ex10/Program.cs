using System;

namespace ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string line;
            line = Console.ReadLine();
            n = int.Parse(line);
            int i = 2;
            bool prim = true;
            while ((i < n / 2) && (prim))
            {
                if (n % i == 0)
                {
                    prim = false;
                 
                }
                i++;
            }
            if (prim) Console.WriteLine("prim ");
            else Console.WriteLine("nu e prim");
        }
    }
}
