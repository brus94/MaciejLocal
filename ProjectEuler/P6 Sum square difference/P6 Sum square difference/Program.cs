using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
The sum of the squares of the first ten natural numbers is,
12 + 22 + ... + 102 = 385

The square of the sum of the first ten natural numbers is,
(1 + 2 + ... + 10)2 = 552 = 3025

Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
*/

namespace P6_Sum_square_difference
{
    class Program
    {
        public static void Main(string[] args)
        {
            long diff = 0;

            var number = 100;

            var sumOfSquares = SumOfSquares(number);
            var squareOfSum = SquareOfSum(number);

            diff = squareOfSum - sumOfSquares;

            Console.WriteLine(diff);
            Console.ReadLine();
        }
        public static long SumOfSquares(long number)
        {
            var sum = 0;
            for (var i = 1; i <= number; i++)
            {
                sum = sum + (i * i);
            }
            return sum;
        }

        public static long SquareOfSum(long number)
        {
            var sum = 0;
            for (var i = 1; i <= number; i++)
            {
                sum = sum + i;
            }
            sum = sum * sum;
            return sum;
        }

    }
}
