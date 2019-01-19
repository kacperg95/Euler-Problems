using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemy_Eulera
{

    //If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
    //If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?
    class Problem17 : IProblem
    {
        public void PrintSolution()
        {
            Console.WriteLine(Solution());
        }


        private int Solution()
        {
            int sum = 0;
            using (StreamWriter sw = new StreamWriter("test.txt"))
            {
                for (int i = 1; i <= 1000; i++)
                {
                    sum += GetNumberLetter(i).Length;

                    sw.WriteLine(GetNumberLetter(i));
                }
            }

            return sum;
        }

        private string GetNumberLetter(int n)
        {
            if (n == 0) return null;
            if (n == 1000) return "onethousand";

            if (n % 100 == 0) return GetNumberLetter(n / 100) + "hundred";
            if (n > 100 && n <= 999) return GetNumberLetter(n/100) + "hundredand" + GetNumberLetter(n - (n / 100 * 100));

            if (n >= 90 && n <= 99) return "ninety" + GetNumberLetter(n - (n/10 * 10));
            if (n >= 80 && n <= 89) return "eighty" + GetNumberLetter(n - (n / 10 * 10));
            if (n >= 70 && n <= 79) return "seventy" + GetNumberLetter(n - (n / 10 * 10));
            if (n >= 60 && n <= 69) return "sixty" + GetNumberLetter(n - (n / 10 * 10));
            if (n >= 50 && n <= 59) return "fifty" + GetNumberLetter(n - (n / 10 * 10));
            if (n >= 40 && n <= 49) return "forty" + GetNumberLetter(n - (n / 10 * 10));
            if (n >= 30 && n <= 39) return "thirty" + GetNumberLetter(n - (n / 10 * 10));
            if (n >= 20 && n <= 29) return "twenty" + GetNumberLetter(n - (n / 10 * 10));

            if (n == 19) return "nineteen";
            if (n == 18) return "eighteen";
            if (n == 17) return "seventeen";
            if (n == 16) return "sixteen";
            if (n == 15) return "fifteen";
            if (n == 14) return "fourteen";
            if (n == 13) return "thirteen";
            if (n == 12) return "twelve";
            if (n == 11) return "eleven";
            if (n == 10) return "ten";

            if (n == 9) return "nine";
            if (n == 8) return "eight";
            if (n == 7) return "seven";
            if (n == 6) return "six";
            if (n == 5) return "five";
            if (n == 4) return "four";
            if (n == 3) return "three";
            if (n == 2) return "two";
            if (n == 1) return "one";
            return null;
        }


    }
}
