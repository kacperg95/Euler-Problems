using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problemy_Eulera
{
    //n! means n × (n − 1) × ... × 3 × 2 × 1

    //For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
    //and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.

    //Find the sum of the digits in the number 100!

    class Problem20 : IProblem
    {
        private const int factorialNumber = 100;

        public void PrintSolution()
        {
            Console.WriteLine($"Sum of the factorial in the number {factorialNumber}: {Solution()}");
        }

        private int Solution()
        {
            string bigNumber = Number.Factorial(factorialNumber).ToString();
            int sum = 0;

            foreach (char c in bigNumber)
                sum += c - '0';
            return sum;
        }

    }
}
