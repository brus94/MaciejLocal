using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A palindromic number reads the same both ways.
//The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
//Find the largest palindrome made from the product of two 3-digit numbers.

namespace P4_Largest_palindrome_product
{
    class Program
    {
        static void Main(string[] args)
        {

            bool result;
            var a = 999;
            var b = 999;
            var x = 0;
            var maxPali = 0;
            while (b > 99)
            {
                x = a * b;
                result = IsPalindrome(x);
                if (result == true)
                {
                    if (x > maxPali)
                    {
                        maxPali = x;
                        Console.WriteLine(a + " * " + b + " = " + x);

                    }
                    
                }
                a--;
                if (a==100)
                {
                    b--;
                    a = 999;
                }
                
            }
           
            Console.ReadLine();


        }

        public static bool IsPalindrome(int number)
        {
            var charArray = number.ToString().ToCharArray();

            for (var i = 0; i < charArray.Length; i++)
            {
                var isEqual = charArray[i] == charArray[charArray.Length - i - 1];
                if (!isEqual)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
