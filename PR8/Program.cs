using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, nr1 = 0, nr2 = 1, nr;
            n = int.Parse(Console.ReadLine());
            if (n > 2)
            {
                for (i = 3; i <= n; i++)
                {
                    nr = nr1 + nr2;
                    nr1 = nr2;
                    nr2 = nr;
                }
                Console.WriteLine("Numarul din sirul lui fibonaci de pe pozita " + n + " este " + nr2);
            }
            else
            {
                if (n==1)
                {
                    Console.WriteLine("Numarul din sirul lui fibonaci de pe pozita " + n + " este " + nr1);
                }
                else
                {
                    Console.WriteLine("Numarul din sirul lui fibonaci de pe pozita " + n + " este " + nr2);
                }
            }
            Console.ReadKey();
        }
    }
}
