using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemy_Eulera
{
    //2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    //What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    public class Problem5 : IProblem
    {
        private int minNumber = 1;
        private int maxNumber = 20;

        public void PrintSolution()
        {
            Console.WriteLine($"Number that is evenly divisible by all of the numbers from {minNumber} to {maxNumber}: {Solution()}");
        }

        private int Solution()
        {
            int result = maxNumber;
            
            while(true)
            {
                for(int i = minNumber; i <= maxNumber; i++)
                {
                    if(!result.DividesBy(i))
                    {
                        result += maxNumber;
                        break;
                    }

                    if (i == maxNumber) return result;
                }
            }
        }
    }
}
