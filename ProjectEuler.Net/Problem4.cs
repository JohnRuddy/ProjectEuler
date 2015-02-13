using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Net
{
    class Problem4 : IProjectEulerProblem
    {
        static bool isPalindrome(string s)
        {
            bool isPalindrome = false;

            var s1 = s;

            var s2 = new String(s1.ToCharArray().Select(x => x).Reverse().ToList<char>().ToArray());

            if (s1 == s2)
            {
                // Console.WriteLine(s1);
                return true;
            }
            return false;
        }

        public void Execute()
        {
            List<int> results = new List<int>();

            for (int i = 100; i <1000; i++)
            {
                for (int j = 100; j <= 1000; j++)
                {   
                    int num  = (i * j);
                    if (isPalindrome("" + num))
                    {
                        results.Add(num);    
                    } 
                    
                }
            }

            var max = (from n in results
                      select n).Max();
            Console.WriteLine("" + max);
        }
    }
}
