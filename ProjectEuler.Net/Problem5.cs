using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Net
{
    class Problem5 : IProjectEulerProblem
    {

        public void Execute()
        {
            Int64 product = 1;

            var i = 1;
            while (!CheckDivisors(i))
            {
                //Console.WriteLine(i);
                i++;
            }
            Console.WriteLine(i);
        }

        private bool CheckDivisors(int j)
        {
            for (int i = 1; i <= 20; i++)
            {
                if (j % i != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
