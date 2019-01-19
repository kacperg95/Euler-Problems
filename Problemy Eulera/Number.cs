using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problemy_Eulera
{
    public static class Number
    {

        public static BigInteger Factorial(int n)
        {
            BigInteger sum = 1;

            for (int i = 2; i <= n; i++)
                sum *= i;
            return sum;
        }


        #region Extensions
        public static bool DividesBy(this int n, int number)
        {
            if (n % number == 0) return true;
            return false;
        }

        //Oblicza sumę dzielników nie licząc tego, który jest równy n
        public static int DivisorsSum(this int n)
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


        public static bool IsEven(this int n)
        {
            if (n % 2 == 0) return true;
            return false;
        }

        public static bool IsPalindrome( this int n)
        {
            string palindrome = n.ToString();

            int begin = 0;
            int end = palindrome.Length - 1;

            for (; begin < end; begin++, end--)
            {
                //Liczba nieparzysta, numery indeksów dotarły do siebie, więc liczba musi być palindromem
                if (begin == end) return true;

                if (palindrome[begin] == palindrome[end])
                    continue;
                else
                    return false;
            }
            return true;
        }

        public static bool IsPrime(this int n)
        {
            if (n == 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            double end = Math.Sqrt(n) + 1;
            for (int i = 3; i < end; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }


        #endregion
    }
}
