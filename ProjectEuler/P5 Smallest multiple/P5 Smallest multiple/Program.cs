using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

namespace P5_Smallest_multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int number = 1; number > 0; number++)
            {
                bool x = IsDevided(number);
                
            }
            Console.ReadLine();
        }

        public static bool IsDevided(int number)
        {
            for (var i = 1; i<=20; i++)
            {
                if (number % i != 0)
                {   
                    return false;
                }
                
                
            }
            Console.WriteLine(number);
            return true;


        }


    }
}
