using System;

namespace pool2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n ,k ,aux ;
            bool cresc = true;
            string line;
            line = Console.ReadLine();
            n = int.Parse(line);
            line = Console.ReadLine();
            aux = int.Parse(line);
            for (int i = 0; i < n-1; i++)
            {
                line = Console.ReadLine();
                k = int.Parse(line);
                if(k<aux)
                {
                    Console.WriteLine("Nu sunt in ordine");
                        cresc = false;
                        break;

                }
                aux = k;

            }
            if(cresc)
            Console.WriteLine("crescator");

        }
    }
}
