using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemy_Eulera
{
    //A palindromic number reads the same both ways.The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    //Find the largest palindrome made from the product of two 3-digit numbers.

    class Problem4 : IProblem
    {
        public void PrintSolution()
        {
            Console.WriteLine($"Biggest palindrom made of multiplicating two 3-digit numbers: {Solution()}");
        }

        private int Solution()
        {
            int biggestPalindrome = 0;
            int nextNumber;

            for(int i = 100; i < 1000; i++)
                for(int j = 100; j < 1000; j++)
                {
                    nextNumber = i * j;
                    if (nextNumber.IsPalindrome() && nextNumber > biggestPalindrome) biggestPalindrome = nextNumber;
                }
            return biggestPalindrome;
        }


    }
}
