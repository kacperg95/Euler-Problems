using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemy_Eulera
{
//You are given the following information, but you may prefer to do some research for yourself.

//1 Jan 1900 was a Tuesday.
//Thirty days has September,
//April, June and November.
//All the rest have thirty-one,
//Saving February alone,
//Which has twenty-eight, rain or shine.
//And on leap years, twenty-nine.
//A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.

//How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?

    class Problem19 : IProblem
    {

        int[] monthDays =
        {
            0,
            31, //Jan
            28, //Feb
            31, //Mar
            30, //Apr
            31, //May
            30, //Jun
            31, //Jul
            31, //Aug
            30, //Sep
            31, //Oct
            30, //Nov
            31  //Dec
        };

        //string[] monthNames = { "zero", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        public void PrintSolution()
        {
            Console.WriteLine($"Number of Sundays during 20th century: {Solution()}");
        }

        //Rozwiązanie bez użycia klasy DateTime
        private int Solution()
        {
            int year = 1901;
            int actualMonth = 1;
            int day = 6;
            int sundays = 1;

            while(true)
            {
                day += 7;

                //Rok przystępny
                if(day/29 == 1 && day % 29 > 0 && actualMonth == 2 && year.DividesBy(4) && (!year.DividesBy(100) || year.DividesBy(400)))
                {
                    day %= 29;
                    actualMonth++;
                }
                else if(day / monthDays[actualMonth] == 1 && day % monthDays[actualMonth] > 0)
                {
                    day %= monthDays[actualMonth];
                    actualMonth++;
                    if(actualMonth == 13)
                    {
                        year++;
                        actualMonth = 1;
                        if (year == 2001)
                            return sundays;
                    }
                }

                if (day == 1)
                {
                    sundays++;
                }
            }
        }
    }
}
