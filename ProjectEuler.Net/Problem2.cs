using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Net
{
    class Problem2 : IProjectEulerProblem
    {
        public void Execute()
        {
            var sequenceLimit = 4000000;
            var sequence = GenerateFibonacci(sequenceLimit);
            Console.WriteLine(sequence.Sum());
            Console.ReadKey();
        }

        private List<int> GenerateFibonacci(int sequenceLimit)
        {
            var num1 = 1;
            var num2 = 2;
            var num3 = 0;

            List<int> numbers = new List<int>();
            numbers.Add(num1);
            numbers.Add(num2);
            
            while (num3 < sequenceLimit)
            {
                num3 = num1 + num2;
                numbers.Add(num3);
                num1 = num2;
                num2 = num3;
            }

            var evens = numbers.Where(n => n % 2 == 0);
            return evens.ToList<int>();
        }
    }
}
