using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            int hex = Convert.ToInt32(Console.ReadLine(),16); //method to convert from 2,8,10 or 16 base to 32-bit Int

            Console.WriteLine(hex);
        }
    }
}
