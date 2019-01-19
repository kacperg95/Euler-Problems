using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problemy_Eulera
{
    //The following iterative sequence is defined for the set of positive integers:

    //n → n/2 (n is even)
    //n → 3n + 1 (n is odd)

    //Using the rule above and starting with 13, we generate the following sequence:

    //13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
    //It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.

    //Which starting number, under one million, produces the longest chain?

    class Problem14 : IProblem
    {
        private const int under = 1_000_000;
        private Dictionary<BigInteger, int> chainMemoization = new Dictionary<BigInteger, int>();


        public void PrintSolution()
        {
            Console.WriteLine($"Number under {under} that produces the longest chain: {Solution()}");
        }

        private int Solution()
        {
            int longestChain = 1;
            int longestChainID = 1;
            int chain = 1;
            for (int i = 1; i < under; i++ )
            {
                chain = ChainLength(i);
                if(chain > longestChain)
                {
                    longestChain = chain;
                    longestChainID = i;
                }
            }
            return longestChainID;
        }

        private int ChainLength(BigInteger n)
        {
            int chainID = (int)n;
            int length = 0;
            if (n == 1) return 1;

            while(n != 1)
            {
                length++;

                if(chainMemoization.ContainsKey(n))
                {
                    length += chainMemoization[n];
                    break;
                }
                
                if (n % 2 == 0)
                    n /= 2;
                else
                    n = 3 * n + 1;

            }
            if (!chainMemoization.ContainsKey(chainID))
                chainMemoization.Add(chainID, length);
            return length;
        }


    }


}
