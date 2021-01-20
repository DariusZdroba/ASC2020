using System;

namespace ex18
{
    class Program
    {
        static bool prim(int k)
        {

            for (int d = 2; d <= k / 2; d++)
            {
                if (k % d == 0) return false;


            }
            return true;

        }
        static void Main(string[] args)
        {
            int n,contor = 0;
            string line;
            line = Console.ReadLine();
            n = int.Parse(line);
            int i = 2;
            bool k = true;
            while (i <= n / 2)
            {
                contor = 0;
                if (k)
                {
                    while (n % i == 0) { 
                        contor++;
                    n = n / i;
                }
                    if(contor>0) Console.WriteLine(i + "^" + contor);
                }
                i++;
                k = prim(i);
                
                            

            }


        }
       
    }
}
