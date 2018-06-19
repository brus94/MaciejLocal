using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

  What is the 10 001st prime number?
 */

namespace P7_10001st_prime
{
    class Program
    {
        static void Main(string[] args)
        {

            var j = 0;
            var i = 2;
            while (j<10001)
            {
                bool result = IsPrimeNumber(i);
                if (result == true) j++;
                i++;
            }
            
            Console.ReadLine();

        }
        public static bool IsPrimeNumber(int number)
        {
            if (number <= 1)
            {
                return false; 
            }
            
            var x = (int)Math.Sqrt(number);
            for (var i = 2; i <= x; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            Console.WriteLine(number);
            return true;
        }
    }
}
