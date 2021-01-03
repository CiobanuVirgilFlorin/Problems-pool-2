using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, poz=0, nr;
            n = int.Parse(Console.ReadLine());
            for (i=1;i<=n;i++)
            {
                nr = int.Parse(Console.ReadLine()); ;
                if (nr == i-1)
                {
                    poz++;
                }
            }
            Console.WriteLine(poz);
            Console.ReadKey;
        }
    }
}
