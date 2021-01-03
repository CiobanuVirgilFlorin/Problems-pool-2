using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, nr, nrpar = 0;
            n = int.Parse(Console.ReadLine());
            for (i=1;i<=n;i++)
            {
                nr = int.Parse(Console.ReadLine());
                if (nr%2==0)
                {
                    nrpar++;
                }
            }
            Console.WriteLine("Numarul de numere pare este " + nrpar);
            Console.ReadKey();
        }
    }
}
