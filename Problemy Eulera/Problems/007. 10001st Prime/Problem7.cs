using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemy_Eulera
{
    //By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
    //What is the 10 001st prime number?

    class Problem7 : IProblem
    {
        private const int number = 10001;

        public void PrintSolution()
        {
            int solution = Solution(number);

            Console.WriteLine($"{number}{CheckNumberEnd(number)} prime number: {solution}");
        }

        private int Solution(int n)
        {
            int counter = 0;
            int result = 0;

            while (counter != n)
            {
                result++;
                if (result.IsPrime())
                    counter++;
            }

            return result;
        } 

        private string CheckNumberEnd(int n)
        {
            switch (n % 10)
            {
                case 1: return "st";
                case 2: return "nd";
                default: return "rd";
            }
        }

    }
}
