using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8_Largest_product_in_a_series
{
    class Program
    {
        static void Main(string[] args)
        {
            string numSeq = "73167176531330624919225119674426574742355349194934969835203127745063262395783180169848018694788518438586156078911294949545950173795833195285320880551112540698747158523863050715693290963295227443043557668966489504452445231617315640309871112172238311362229893423380308135336276614282806444486645238749303589072962904915604407723907138105158593079608667017242712188399879790879227492190169972088809377665727333001053367881220235421809751254540594752243525849077116705560136048395864467063244157221553975369781797784617406495514929086256932197846862248283972241375657056057490261407972968652414535100474";
            double sum;
            double maxsum = -1;
            List<Double> adjecent = new List<double>();

            for (int i = 0; i <numSeq.Length - 13; i++)
            {
                sum = 1;
                foreach (char c in numSeq.Substring(i,13))
                {
                    sum *= double.Parse(c.ToString());
                }
                if (sum>=maxsum)
                {
                    maxsum = sum;
                }
            }
                        
            Console.WriteLine(maxsum);
            Console.ReadLine();

        }
    }
}
