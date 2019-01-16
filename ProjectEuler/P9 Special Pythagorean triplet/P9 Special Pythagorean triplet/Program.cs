using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Problem 9 
A Pythagorean triplet is a set of three natural numbers, a < b<c, for which,

a2 + b2 = c2
For example, 32 + 42 = 9 + 16 = 25 = 52.

There exists exactly one Pythagorean triplet for which a + b + c = 1000.
Find the product abc.
*/

namespace P9_Special_Pythagorean_triplet
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int a = 1;
            int b = 2;
            int c = 3;
            
            

            for (; ;)
            {
                int sumabc = a + b + c;


                if (a * a + b * b == c * c)
                {
                    if (sumabc == 1000) {
                        Console.WriteLine("A:"+a+ " B:"+b+" C:"+c);
                        Console.WriteLine("A<B<C");
                        Console.WriteLine(a + "+" + b + "+" + c + "=" + sumabc);
                        Console.WriteLine("Answer is: abc = "+a*b*c);
                        Console.ReadLine();
                    }

                    
                }
                
               
                    //Console.WriteLine(c);
                    a = a + 1;
                    if (a == b)
                    {
                        b = b + 1;
                        a = 1;
                    }

                    if (b == c)
                    {
                        c = c + 1;
                        a = 1;
                        b = 2;
                    }

                }
            }
        }
    }


