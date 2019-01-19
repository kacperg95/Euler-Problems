using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemy_Eulera
{
    //The sum of the squares of the first ten natural numbers is,
    //1^2 + 2^2 + ... + 10^2 = 385

    //The square of the sum of the first ten natural numbers is,
    //(1 + 2 + ... + 10)^ = 55^2 = 3025

    //Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
    //Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
    class Problem6 : IProblem
    {

        private const int numbers = 100;

        public void PrintSolution()
        {
            Console.WriteLine($"Square of the sum minus Sum of the squares for first {numbers} numbers: {Solution(numbers)}");
        }

        private int Solution(int n)
        {
            return SquareOfSum(n) - SumOfSqares(n);
        }

        private int SumOfSqares(int n)
        {
            int sum = 0;
            for(int i = 1; i <= 100; i++)
                sum += (int)Math.Pow(i, 2);
            return sum;
        }

        private int SquareOfSum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
                sum += i;
            return (int)Math.Pow(sum, 2);
        }

    }
}
