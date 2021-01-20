using System;

namespace pool2._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,k,auxMin, auxMax;
            bool monotonMax = true, monotonMin = true;
            string line;
            line = Console.ReadLine();
            n = int.Parse(line);

            line = Console.ReadLine();
            k = int.Parse(line);
            auxMax = k;
            auxMin = k;

            int i = 1;
            while((i < n)&&((monotonMax) ||(monotonMin)))
            {
                line = Console.ReadLine();
                k = int.Parse(line);
                if (k < auxMax) monotonMax = false;
                else auxMax = k;
                if (k > auxMin) monotonMin = false;
                else auxMin = k;
                i++;
            }

            if ((monotonMin) || (monotonMax)) Console.WriteLine("monoton");
            else Console.WriteLine("nu e monoton");
        }
    }
}
