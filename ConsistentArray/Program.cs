using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsistentArray
{
    class Program
    {
        static int? FirstNonConsecutiveElement(int[] Array)
        {

           int? value = null;


            for(int i = 1; i < Array.Length; i++)
            {
                if (Array[i] - 1 != Array[i - 1])
                {

                    value = Array[i];
                    break;
                }
               
            }
            return value;

        }
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 1, 2, 3, 4, 6, 7 };


            Console.WriteLine(FirstNonConsecutiveElement(myArray));

            Console.ReadLine();
        }
    }
}
