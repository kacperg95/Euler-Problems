using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problemy_Eulera
{

    //Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.
    //How many such routes are there through a 20×20 grid?
    class Problem15 : IProblem
    {
        private const int gridSize = 21; //21 a nie 20, ponieważ będziemy poruszać się po polach siatki, a nie po liniach.

        private BigInteger[,] grid = new BigInteger[gridSize, gridSize]; 

        public void PrintSolution()
        {
            Console.WriteLine($"Number of routes through a {gridSize-1}x{gridSize-1} grid: {Solution()}");
        }

        private BigInteger Solution()
        {
            for(int i = 0; i < gridSize; i++)
            {
                grid[i, gridSize - 1] = 1;
                grid[gridSize - 1, i] = 1;
            }

            for(int i = gridSize - 2; i >= 0; i--)
                for(int j = gridSize -2; j >= 0; j --)
                {
                    grid[i, j] = grid[i + 1, j] + grid[i, j + 1];
                    if (i == 0 && j == 0)
                        return grid[i, j];
                }
            return 0;
        }


    }
}
