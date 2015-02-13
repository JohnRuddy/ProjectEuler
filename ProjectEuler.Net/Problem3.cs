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
        public void Execute()
        {
            long number = 600851475143L;
            int factor = 3;
            while (number > 1)
            {
                if (number % factor == 0)
                {
                    number /= factor;
                }
                else
                {
                    factor += 2;
                }
            }
            Console.WriteLine(factor);
        }
    }
}
