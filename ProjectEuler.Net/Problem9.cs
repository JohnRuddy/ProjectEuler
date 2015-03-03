using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Net
{
    class Problem9 : IProjectEulerProblem
    {

        /// <summary>
        /*
         A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
            a2 + b2 = c2
         
            For example, 32 + 42 = 9 + 16 = 25 = 52.

            There exists exactly one Pythagorean triplet for which a + b + c = 1000.
            Find the product abc.
         */
        /// </summary>
        public void Execute()
        {
            int length = 1000;


            for (int a = 1; a < length; a++)
            {
                for (int b = 1; b < length - 1; b++)
                {
                    int c = length - a - b;
                    if ((a * a) + (b * b) == (c * c))
                    {
                        Console.WriteLine(a * b * c);
                        return;
                    }
                }

            }
        }
    }
}
