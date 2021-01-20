using System;

namespace Ex15
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            string line;
            line = Console.ReadLine();
            a = int.Parse(line);
            line = Console.ReadLine();
            b = int.Parse(line);
            line = Console.ReadLine();
            c = int.Parse(line);

          /*  if (a > b)
            { if (b >= c) Console.WriteLine(a + " " + b + " "+ c);
               if(b<c)
                { if (a >= c) Console.WriteLine(a + " " + c + " " + b);
                    if(a<c) Console.WriteLine(c + " " + a + " " + b);
                } 
            }
        */
            if((a>b)&&(a>c)) if(b>c) Console.WriteLine(c + " " + b + " " + a);
            else Console.WriteLine(b + " " + c + " " + a);

            if ((b > a) && (b > c)) if (a > c) Console.WriteLine(c + " " + a + " " + b);
                else Console.WriteLine(a + " " + c + " " + b);
            if ((c > b) && (c > a)) if (b > a) Console.WriteLine(a + " " + b + " " + c);
                else Console.WriteLine(b + " " + a + " " + c);
        }
    }
}
