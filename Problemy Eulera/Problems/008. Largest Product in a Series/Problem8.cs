﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problemy_Eulera
{

    //The four adjacent digits in the 1000-digit number that have the greatest product are 9 × 9 × 8 × 9 = 5832.
    //Find the thirteen adjacent digits in the 1000-digit number that have the greatest product. What is the value of this product?
    class Problem8 : IProblem
    {

        private string digits = "858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
        private const int adjacent = 13;

        public void PrintSolution()
        {
            Console.WriteLine($"{adjacent} adjacent digits in the 1000-digits number that have the greatest product: {Solution()}");
        }

        public BigInteger Solution()
        {
            BigInteger biggestProduct = 0;
            BigInteger currentProduct;

            for(int i = 0; i < digits.Length - adjacent; i++)
            {
                bool thereIsZero = false;
                string number = digits.Substring(i, adjacent);

                currentProduct = 1;

                for (int j = 0; j < adjacent; j++)
                {            
                    int n = number[j] - '0'; //Konwersja z char na int
                    if (n == 0)
                    {
                        thereIsZero = true;
                        break;
                    }            
                    currentProduct *= n;
                }

                if (thereIsZero)
                    continue;

                if (currentProduct > biggestProduct)
                    biggestProduct = currentProduct;
            }
            return biggestProduct;
        }
    }
}
