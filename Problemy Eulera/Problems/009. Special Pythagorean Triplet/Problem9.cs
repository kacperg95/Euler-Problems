using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemy_Eulera
{

    //A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,

    //a^2 + b^2 = c^2
    //For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.

    //There exists exactly one Pythagorean triplet for which a + b + c = 1000.
    //Find the product abc.

    public class Problem9 : IProblem
    {
        public const int sum = 1000;

        public void PrintSolution()
        {
            Console.WriteLine($"a*b*c for which a+b+c = 1000: {Solution()}");
        }

        private int Solution()
        {
            for(int a = 3; a < sum/2; a++)
                for(int b = a + 1; b < sum/2; b++)
                {
                    double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

                    if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                        if (a + b + c == 1000)
                            return Convert.ToInt32(a * b * c);
                }
            return 0;
        }

    }
}
