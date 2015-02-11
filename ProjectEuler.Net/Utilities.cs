using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Net
{
    class Utilities
    {
        public static bool isPrime(int number)
        {
            var num = Convert.ToDouble(number);
            var res = Math.Sqrt(num);
            var boundary = Math.Floor(res);

            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
