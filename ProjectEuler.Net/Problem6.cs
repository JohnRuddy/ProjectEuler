using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Net
{
    class Problem6 : IProjectEulerProblem
    {
        public void Execute()
        {
            Int64 squareSum = 0;
            Int64 sum = 0;

            int length = 100;

            for (int i = 0; i <= length; i++)
            {
                squareSum = squareSum + (i * i);
                sum = sum + i;
            }

            var diff = (sum * sum) - squareSum;
            Console.WriteLine(diff);
        }
    }
}
