using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10B_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(returnSumOrThirdValue(4, 5, 7));
            Console.WriteLine(returnSumOrThirdValue(7, 4, 12));
            Console.WriteLine(returnSumOrThirdValue(10, 10, 12));
            Console.WriteLine(returnSumOrThirdValue(12, 12, 18));

            Console.ReadLine();


        }
        //compute the sum of three given integers.
        //Return the third value if the two values are the same.
        public static int returnSumOrThirdValue(int num1,int num2, int num3)
        {
            int sum= num1 + num2 +num3;
            if(num1 == num2 || num1 == num3 || num2 == num3)
            {
                return num3;
            }
            return sum;
        }
    }
}
