using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, ok=1, nr, i, ant;
            n = int.Parse(Console.ReadLine());
            ant = int.Parse(Console.ReadLine());
            for (i=2;i<=n;i++)
            {
                nr = int.Parse(Console.ReadLine());
                if (nr<ant)
                {
                    ok = 0;
                }
                ant = nr;
            }
            if (ok==1)
            {
                Console.WriteLine("Da sunt in ordine crescatoare");
            }
            else
            {
                Console.WriteLine("Nu sunt in ordine crescatoare");
            }
        }
    }
}
