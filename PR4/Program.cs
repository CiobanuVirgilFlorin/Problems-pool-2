using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, a, poz = -1, nr;
            n = int.Parse(Console.ReadLine());
            a = int.Parse(Console.ReadLine());
            for (i=1;i<=n;i++)
            {
                nr = int.Parse(Console.ReadLine());
                if (nr==a)
                {
                    poz = i - 1;
                }
            }
            if (poz!=-1)
            {
                Console.WriteLine("Numarul " + a + " se gaseste pe pozitai " + poz);
            }
            else
            {
                Console.WriteLine("-1");
            }
            Console.ReadKey();
        }
    }
}
