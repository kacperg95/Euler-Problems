using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemy_Eulera
{
    class Program
    { 
        static void Main(string[] args)
        {
            IProblem problem = new Problem30();
            problem.PrintSolution();
            Console.ReadKey();
        }
    }
}
