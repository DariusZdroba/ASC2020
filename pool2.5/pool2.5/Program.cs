using System;

namespace pool2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int Contorpozitie = 0;
            string line;
            line = Console.ReadLine();
            n = int.Parse(line);
          
            for (int i = 0; i < n; i++)
            {
                line = Console.ReadLine();
                int k = int.Parse(line);
                if (k == i) Contorpozitie ++;

            }
            Console.WriteLine(Contorpozitie + " numere ");

        }
    }
}
