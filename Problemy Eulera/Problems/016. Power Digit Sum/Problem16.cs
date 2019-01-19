using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problemy_Eulera
{
    //2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
    //What is the sum of the digits of the number 2^1000?
    class Problem16 : IProblem
    {
        private const int index = 1000;

        public void PrintSolution()
        {
            Console.WriteLine($"Sum of the digits of the number 2^{index}: {Solution()}");
        }

        private int Solution()
        {
            BigInteger bigNumber = (BigInteger)Math.Pow(2, index);
            string number = bigNumber.ToString();
            int sum = 0;
            foreach(char c in number)
            {
                sum += c - '0';
            }
            return sum;
        }

    }
}
