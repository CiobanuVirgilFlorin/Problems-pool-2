using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, nr, mic, mare, i;
            n = int.Parse(Console.ReadLine());
            nr = int.Parse(Console.ReadLine());
            mic = nr;
            mare = nr;
            for (i=2;i<=n;i++)
            {
                nr = int.Parse(Console.ReadLine());
                if (nr<mic)
                {
                    mic = nr;
                }
                if (nr>mare)
                {
                    mare = nr;
                }
            }
            Console.WriteLine("Cel mai mare numar este " + mare + "cel mai mic este " + mic);
            Console.ReadKey();
        }
    }
}
