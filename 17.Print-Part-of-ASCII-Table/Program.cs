using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Print_Part_of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var staringNum = int.Parse(Console.ReadLine());
            var endingNum = int.Parse(Console.ReadLine());

            char startingSymbol = (char)staringNum;
            char endingSymbol = (char)endingNum;

            for (char i = startingSymbol; i <= endingSymbol; i++)
            {
                Console.Write(i+" ");
            }
        }
    }
}
