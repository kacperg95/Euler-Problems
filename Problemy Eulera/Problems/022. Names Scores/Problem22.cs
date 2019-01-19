using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problemy_Eulera
{
    //Using names.txt(right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand first names, begin by sorting it into alphabetical order.Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list to obtain a name score.

    //For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list. So, COLIN would obtain a score of 938 × 53 = 49714.
    //What is the total of all the name scores in the file?
    class Problem22 : IProblem
    {
        private const int asciiCode = 64; // Odjęcie tej liczby od kodu ascii danej litery wyświetli jej wynik np. A=65, 65-64=1        

        public void PrintSolution()
        {
            Console.WriteLine($"Total of all the name scores in the file: {Solution()}");
        }


        public BigInteger Solution()
        {
            List<string> names = GetNamesList();
            names.Sort();

            BigInteger sum = 0;

            for(int i = 0; i < names.Count; i++)
            {
                int nameScore = 0;
                foreach (char c in names[i])
                    nameScore += Convert.ToInt32(c) - asciiCode;
                nameScore *= i + 1;
                sum += nameScore;
            }

            return sum;
        }

        private List<string> GetNamesList()
        {
            List<string> names = new List<string>();

            string [] namesArray = ReadAllNamesFromFile("p022_names.txt");

            foreach (string s in namesArray)
                names.Add(s.Substring(1, s.Length - 2)); //Substring służy usunięciu cudzysłowów
            return names;
        }

        private string [] ReadAllNamesFromFile(string fileName)
        {
            string namesBlock = string.Empty;
            if (File.Exists(fileName))
                namesBlock = File.ReadAllText(fileName);
            return namesBlock.Split(',');
        }
    }
}
