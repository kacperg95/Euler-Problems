using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemy_Eulera
{

    //A unit fraction contains 1 in the numerator.The decimal representation of the unit fractions with denominators 2 to 10 are given:

    //1/2	= 	0.5
    //1/3	= 	0.(3)
    //1/4	= 	0.25
    //1/5	= 	0.2
    //1/6	= 	0.1(6)
    //1/7	= 	0.(142857)
    //1/8	= 	0.125
    //1/9	= 	0.(1)
    //1/10	= 	0.1
    //Where 0.1(6) means 0.166666..., and has a 1-digit recurring cycle.It can be seen that 1/7 has a 6-digit recurring cycle.

    //Find the value of d< 1000 for which 1/d contains the longest recurring cycle in its decimal fraction part.
    class Problem26 : IProblem
    {

        private const int limit = 1000;

        public void PrintSolution()
        {
            Console.WriteLine($"Value with the longest recurring cycle of d < {limit}: {Solution()}");
        }

        private int Solution()
        {
            int longestRecurringCycle = 0;
            int index = 0;

            for(int i = 1; i < limit; i++)
            {
                Console.WriteLine(i);
                List<int> remainders = new List<int>();

                int divide = 1;

                while(true)
                {
                    bool breakTheLoop = false;
                    int remainder = divide % i;
                    if (remainder == 0) break;

                    if(remainders.Contains(remainder))
                    {
                        for(int j = 0; j < remainders.Count; j++)
                        {
                            if(remainders[j] == remainder)
                            {
                                int recurringCycle = remainders.Count - j;
                                if (recurringCycle > longestRecurringCycle)
                                {
                                    longestRecurringCycle = recurringCycle;
                                    index = i;
                                    breakTheLoop = true;
                                    break;
                                }
                                else
                                {
                                    breakTheLoop = true;
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        remainders.Add(remainder);
                        divide = remainder * 10;
                    }

                    if (breakTheLoop) break;
                    if (remainders.Count >= i + 1) break;
                }             
            }
            return index;
        }

    }
}
