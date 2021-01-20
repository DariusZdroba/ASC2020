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
            Console.WriteLine("dati numarul n care reprezinta cate numere sunt in sir ");
            line = Console.ReadLine();
            n = int.Parse(line);
          
            Console.WriteLine("dati numarul A care va fi vericiat pe ce pozitie este in sir");
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
