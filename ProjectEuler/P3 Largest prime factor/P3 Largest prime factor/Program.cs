using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// prime factors of 13195 are 5, 7, 13 and 29.
// What is the largest prime factor of the number 600851475143 ?

namespace P3_Largest_prime_factor
{
    class Program
    {

        static void Main(string[] args)    
        {
            var number = 600851475143;

            for (var p = 1; p<=Math.Sqrt(number); p++)
                if (number % p == 0)
                {
                    bool result = IsPrimeNumber(p);
                    if (result == true) Console.WriteLine(p);
                }


           Console.ReadLine();
        }

        public static bool IsPrimeNumber(int factorOfNumber)
        {
            if (factorOfNumber <= 1)
            {
                return false; // because definition
            }

            var x = (int)Math.Sqrt(factorOfNumber);
            for (var i = 2; i <= x; i++)
            {
                if (factorOfNumber % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

    }
}
