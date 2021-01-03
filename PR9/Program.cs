using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, ok=2, nr, ant;
            n = int.Parse(Console.ReadLine());
            ant = int.Parse(Console.ReadLine());
            for (i=2;i<=n;i++)
            {
                nr = int.Parse(Console.ReadLine());
                if (nr<ant && ok == 2)
                {
                    ok = 1;
                }
                else if (ant > nr && ok == 2)
                {
                    ok = -1;
                }
                if (nr<ant && ok==1)
                {
                    ok = 0;
                }    
                else if (nr>ant && ok==-1)
                {
                    ok = 0;
                }
                ant = nr;
            }
            if (ok == 1 || ok == -1)
            {
                Console.WriteLine("Sirul este monoton");
            }
            else
            {
                Console.WriteLine("Sirul nu este monoton");
            }
            Console.ReadKey();
        }
    }
}
