using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Explicatia mea este urmatoarea: conform legii lui Moore, puterea de calcul creste de 2 ori la fiecare 18 luni
 * adica 1.5 ani, inseamna ca puterea de calcul x creste *2^(ani/1.5).
 * Presupunem ca initial x = 1, inseamna ca n -ul va fi egal cu 2^(ani/1.5), deci ani = (log2 100)*1.5
 
 */
namespace ASC_Tema1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numar;
            Console.Write("Introduceti numarul n = ");
            numar = int.Parse(Console.ReadLine());
            Console.Write($"Puterea de calcul va fi de {numar} mai mare dupa ");
            Console.Write(Math.Log(numar, 2) * 1.5);
            Console.Write(" ani  ");
        }
    }
}
