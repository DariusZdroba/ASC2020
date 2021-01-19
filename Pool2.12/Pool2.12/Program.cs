using System;

namespace Pool2._12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, numar, contor = 0 , contor2 = 0; 
            string line;
            line = Console.ReadLine();
            n = int.Parse(line);
            for(int i = 1; i <= n; i++)
            {
                line = Console.ReadLine();
                numar = int.Parse(line);
                if (numar != 0) contor++;
                if (numar == 0)
                {
                    if (contor != 0) contor2++;
                    contor = 0;
                }
                }
            Console.WriteLine(contor2);


        }
    }
}
