using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemy_Eulera
{
    //Let d(n) be defined as the sum of proper divisors of n(numbers less than n which divide evenly into n).
    //If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.

    //For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; therefore d(220) = 284. The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.

    //Evaluate the sum of all the amicable numbers under 10000.
    class Problem21 : IProblem
    {
        private const int under = 10000;

        public void PrintSolution()
        {
            Console.WriteLine($"Sum of all amicable numbers under {under}: {Solution()}");
        }

        public int Solution()
        {
            int sum = 0;
            for(int i = 1; i < under; i++)
            {
                int a = i.DivisorsSum(); ;

                if (a.DivisorsSum() == i && a != i)
                    sum += i;

            }
            return sum;
        }


        //Oblicza sumę dzielników nie licząc tego, który jest równy n
        private int DivisorsSum(int n)
        {
            int sum = 1;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n.DividesBy(i))
                {
                    if (n / i == i)
                    {
                        sum += i;
                    }
                    else
                    {
                        sum += i;
                        sum += n / i;
                    }
                }
            }
            return sum;
        }


    }
}
