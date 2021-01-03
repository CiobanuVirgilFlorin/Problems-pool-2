using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, p=1, s=0;
            n = int.Parse(Console.ReadLine());
            for (i=1;i<=n;i++)
            {
                s = s + i;
                p = p * i;
            }
            Console.WriteLine("Suma numerelor de la 1 la " + n + " este " + s + " iar produsul este " + p );
            Console.ReadKey();
        }
    }
}
