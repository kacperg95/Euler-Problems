using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problemy_Eulera
{

    //The prime factors of 13195 are 5, 7, 13 and 29.
    //What is the largest prime factor of the number 600851475143 ?

    class Problem3 : IProblem
    {
        private BigInteger number = 1000;

        public void PrintSolution()
        {
            Console.WriteLine($"Largest prime factor of the number {number}: {Solution(number)}");
        }

        private int Solution(BigInteger n)
        {
            int largestPrimeFactor = -1;

            while (n % 2 == 0)
            {
                n /= 2;
                largestPrimeFactor = 2;
            }

            for (int i = 3; i < Math.Sqrt((double)n); i += 2)
            {
                while (n % i == 0)
                {
                    largestPrimeFactor = i;
                    n /= i;
                }
            }

            if (n > 2) largestPrimeFactor = (int)n;

            return largestPrimeFactor;
        }

    }
}
