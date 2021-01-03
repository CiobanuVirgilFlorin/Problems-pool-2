using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, nr, nrpoz = 0, nrneg = 0, nrzero = 0;
            n = int.Parse(Console.ReadLine());
            for (i=1;i<=n;i++)
            {
                nr = int.Parse(Console.ReadLine());
                if (nr<0)
                {
                    nrneg++;
                }
                else if (nr==0)
                {
                    nrzero++;
                }
                else
                {
                    nrpoz++;
                }
            }
            Console.WriteLine("In sir sunt " + nrpoz + " numere pozitive " + nrneg + " numere negative si " + nrzero + " valori de zero");
            Console.ReadKey();
        }
    }
}
