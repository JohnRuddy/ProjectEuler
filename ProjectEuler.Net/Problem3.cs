/*
        The prime factors of 13195 are 5, 7, 13 and 29.
        What is the largest prime factor of the number 600851475143 ?
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Net
{
    class Problem3 : IProjectEulerProblem
    {
        static bool IsPrime(double number)
        {

            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)
            {
                if (number % i == 0) return false;
            }

            return true;

        }

        public void Execute()
        {
            double number = 600851475143;
            List<double> primes = new List<double>();

            for (double i = 1; i < number; i++)
            {
                if (IsPrime(i))
                {
                    if (number % i == 0)
                    {
                        primes.Add(i);            
                    }
                }
            }

            Console.WriteLine(primes.Max());
            Console.ReadKey();
        }
    }
}
