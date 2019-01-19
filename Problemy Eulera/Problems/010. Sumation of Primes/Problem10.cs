using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problemy_Eulera
{

    //The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
    //Find the sum of all the primes below two million.
    class Problem10 : IProblem
    {
        private const int maxNumber = 2_000_000;

        public void PrintSolution()
        {
            Console.WriteLine($"Sum of all the primes below {maxNumber}: {Solution()}");
        }

        private BigInteger Solution()
        {
            int n = 1;
            BigInteger sum = 0;
            while(n < 2_000_000)
            {
                if (n.IsPrime())
                    sum += n;
                n++;
            }
            return sum;
        }


    }
}
