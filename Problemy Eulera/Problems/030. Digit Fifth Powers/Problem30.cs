using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemy_Eulera
{
    //Surprisingly there are only three numbers that can be written as the sum of fourth powers of their digits:

    //1634 = 1^4 + 6^4 + 3^4 + 4^4
    //8208 = 8^4 + 2^4 + 0^4 + 8^4
    //9474 = 9^4 + 4^4 + 7^4 + 4^4
    //As 1 = 1^4 is not a sum it is not included.

    //The sum of these numbers is 1634 + 8208 + 9474 = 19316.

    //Find the sum of all the numbers that can be written as the sum of fifth powers of their digits.
    class Problem30 : IProblem
    {
        private const int power = 5;

        private List<int> fifthPowers = new List<int>();

        public void PrintSolution()
        {
            Console.WriteLine($"Sum of all numbers that can be written as the sum of fifth powers of their digits: {Solution()}");
        }

        private int Solution()
        {
            for(int i = 2; i < 1000000; i++)
            {
                int sum = 0;
                int divider = 10;
              
                while(divider/10 < i)
                {
                    int digit = i % divider / (divider / 10);
                    sum += (int)Math.Pow(digit, power);
                    divider *= 10;
                }

                if (sum == i)
                {
                    fifthPowers.Add(i);
                    Console.WriteLine(i);
                }


            }

            return fifthPowers.Sum();
        }

    }
}
