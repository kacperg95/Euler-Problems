using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemy_Eulera
{
    //Euler discovered the remarkable quadratic formula:

    //n^2+n+41
    //It turns out that the formula will produce 40 primes for the consecutive integer values 0≤n≤39. However, when n = 40,40^2+40+41=40(40+1)+41 is divisible by 41, and certainly when n = 41,41^2+41+41 is clearly divisible by 41.

    //The incredible formula n^2−79n+1601 was discovered, which produces 80 primes for the consecutive values 0≤n≤79. The product of the coefficients, −79 and 1601, is −126479.

    //Considering quadratics of the form:

    //n^2+an+b, where |a|<1000 and |b|≤1000

    //where |n| is the modulus/absolute value of n
    //e.g. |11|=11 and |−4|=4
    //Find the product of the coefficients, a and b, for the quadratic expression that produces the maximum number of primes for consecutive values of n, starting with n = 0.
    class Problem27 : IProblem
    {
        int maxA = 0, maxB = 0, maxPrimes = 0;

        public void PrintSolution()
        {
            Console.WriteLine($"Product of a and b: {Solution()}");
        }

        private int Solution()
        {

            for (int a = -999; a <= 1000; a+=2)
            {
                for (int b = -999; b <= 1000; b+=2)
                {
                    if (!b.IsPrime()) continue;

                    int primes = CountConsecutivePrimes(a, b);

                    if(primes > maxPrimes)
                    {
                        maxA = a;
                        maxB = b;
                        maxPrimes = primes;
                    }

                }
            }
            return maxA * maxB;
        }


        private int CountConsecutivePrimes(int a, int b)
        {
            int n = 0;
            while(true)
            {
                int result = (n * n) + (a * n) + b;
                if (Math.Abs(result).IsPrime())
                    n++;
                else
                    return n - 1;
            }

        }

    }
}
