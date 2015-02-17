using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Net
{
    class Problem7 : IProjectEulerProblem
    {
        bool isPrime(Int64 n)
        { 
            //# look for factors of 2 first
            // if n % 2 == 0: return False
            //# now look for odd factors
            //p = 3
            //while p < n**0.5+1:
            //if n % p == 0: return False
            //p += 2
            //return True            
            var p = 3;
            if (n % 2 == 0)
            {
                return false;
            }
            while (p < (n / 2) + 1)
            {
                if (n % p == 0)
                {
                    return false;
                }
                p += 2;
            }

            return true;
        }

        public void Execute()
        {
            var i = 10001;
            var n = 0;
            while (i > 0)
            {
                n++;
                if (isPrime(n))
                {
                    // Console.WriteLine(n);
                    i = i - 1;
                }
        
            }

            Console.WriteLine(n);
        }
    }
}
