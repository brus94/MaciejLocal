using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

Find the sum of all the primes below two million.
**/



namespace P10_Summation_of_primes
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            for (double i = 0; i<2000000; i++)
            {
                bool p = IsPrimeNumber(i);
                if (p == true) sum = sum + i;
            }

            Console.WriteLine(sum);
            Console.ReadLine();

        }

        public static bool IsPrimeNumber(double factorOfNumber)
        {
            if (factorOfNumber <= 1)
            {
                return false; // because definition
            }

            var x = (double)Math.Sqrt(factorOfNumber);
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
