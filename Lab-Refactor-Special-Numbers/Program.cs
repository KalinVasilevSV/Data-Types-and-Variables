using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lab exercise to correct bad code for readability

            int num = int.Parse(Console.ReadLine());
            bool isSpecial = false;

            for (int i = 1; i <= num; i++)
            {
                var sumOfDigits = 0;
                var saveCurrentIteration = i;
                while (i > 0)
                {
                    sumOfDigits += i % 10;
                    i= i/ 10;
                }
                isSpecial = (sumOfDigits== 5) || (sumOfDigits== 7) || (sumOfDigits== 11);
                Console.WriteLine($"{saveCurrentIteration} -> {isSpecial}");
                sumOfDigits= 0;
                i = saveCurrentIteration;
            }
        }
    }
}
