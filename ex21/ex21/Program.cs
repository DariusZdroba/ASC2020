using System;

namespace ex21
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            int a;
            line = Console.ReadLine();
            a = int.Parse(line);
            int k = 512;
               if ((a >= 1) && (a <= 1024))
            {
                Console.WriteLine("Daca numarul ales este mai mare decat " + k + "apasati 1");
                Console.WriteLine("Altfel apasati 0");
                line = Console.ReadLine();
                if(line == "1") 
                

            }


        }
    }
}
