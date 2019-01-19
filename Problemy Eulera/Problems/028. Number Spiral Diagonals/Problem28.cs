using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problemy_Eulera
{
    //Starting with the number 1 and moving to the right in a clockwise direction a 5 by 5 spiral is formed as follows:

    //21 22 23 24 25
    //20  7  8  9 10
    //19  6  1  2 11
    //18  5  4  3 12
    //17 16 15 14 13

    //It can be verified that the sum of the numbers on the diagonals is 101.

    //What is the sum of the numbers on the diagonals in a 1001 by 1001 spiral formed in the same way?

    class Problem28 : IProblem
    {
        private const int arraySize = 1001;

        public void PrintSolution()
        {
            Console.WriteLine($"Diagonal sum of spiral {arraySize}x{arraySize} : {Solution()}");
        }

        private BigInteger Solution()
        {
            int[,] spiral = BuildSpiral();
            return DiagonalSum(spiral);
        }


        private int [,] BuildSpiral()
        {
            int i = 1, row = arraySize / 2, col = arraySize / 2;
            Direction dir = Direction.Right;
            int straightJumps = 1;
            int numberOfStraightMoves = 0;
            

            int[,] array = new int[arraySize, arraySize];

            while (true)
            {
                for(int j = 0; j < straightJumps; j++)
                {
                    array[row, col] = i;
                    i++;


                    row += MoveRow(dir);
                    col += MoveColumn(dir);

                    if (col >= arraySize || col < 0 || row >= arraySize || row < 0)
                        return array;
                }

                numberOfStraightMoves++;

                if(numberOfStraightMoves == 2)
                {
                    numberOfStraightMoves = 0;
                    straightJumps++;                    
                }

                int dirInteger = (int)dir;
                dirInteger++;
                dirInteger %= 4;
                dir = (Direction)dirInteger;


            }
        }

        private int MoveRow(Direction dir)
        {
            switch(dir)
            {
                case Direction.Left:
                    return 0;
                case Direction.Up:
                    return -1;
                case Direction.Right:
                    return 0;
                case Direction.Down:
                    return 1;
                default:
                    return 0;
            }
        }

        private int MoveColumn(Direction dir)
        {
            switch (dir)
            {
                case Direction.Left:
                    return -1;
                case Direction.Up:
                    return 0;
                case Direction.Right:
                    return 1;
                case Direction.Down:
                    return 0;
                default:
                    return 0;
            }
        }


        private BigInteger DiagonalSum(int [,] array)
        {
            BigInteger sum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
                sum += array[i, i];

            for(int i = 0, j = array.GetLength(1) - 1; i < array.GetLength(0); i++, j--)
            {
                sum += array[i, j];
            }

            return sum;

        }



    }

    public enum Direction
    {
        Right,
        Down,
        Left,
        Up,
    }


}
