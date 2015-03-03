using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Net
{
    class Problem10 : IProjectEulerProblem
    {

        public void Execute()
        {
            Int64 primeSum = 0;
            var length = 2000000;

            for (int i = 2; i <= length; i++)
            {
                if (IsPrime(i) || i == 2)
                {
                    primeSum = primeSum + i;
                }
            }   

            // finally print out the result
            Console.WriteLine(primeSum);
        }

        public bool IsPrime(Int64 number)
        {
            if (number < 2) return false;
            if (number % 2 == 0) return (number == 2);
            int root = (int)Math.Sqrt((double)number);
            for (int i = 3; i <= root; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}


