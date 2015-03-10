using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Net
{
    class Problem12 : IProjectEulerProblem
    {
        public List<int> Factor(int number)
        {
            List<int> factors = new List<int>();
            int max = (int)Math.Sqrt(number);  //round down
            for (int factor = 1; factor <= max; ++factor)
            { //test from 1 to the square root, or the int below it, inclusive.
                if (number % factor == 0)
                {
                    factors.Add(factor);
                    if (factor != number / factor)
                    { // Don't add the square root twice!  Thanks Jon
                        factors.Add(number / factor);
                    }
                }
            }
            return factors;
        }

        public void Execute()
        {
            var factors = new List<int>();
            int i = 0;
            var j = 0;

            // create the list of the triangle numbers
            while (true)
            {
                j = j + i;
                factors = Factor(j);
                if (factors.Count > 500)
                {
                    break;
                }
                i++;
            }

            Console.WriteLine(j);

            
        }
    }
}
