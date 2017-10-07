using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int deciNum = int.Parse(Console.ReadLine());

            string hexNum = deciNum.ToString("X"); //converts int value to hexadecimal in string format, can specify digits by adding a digit to "X"
            Console.WriteLine(hexNum);

            string hexNumSecond = Convert.ToString(deciNum, 16).ToUpper();//another way to convert to hex represetation in string format
            Console.WriteLine(hexNumSecond);

            string binaryNum = Convert.ToString(deciNum, 2); //converts int to binary reperesentation in string format
            Console.WriteLine(binaryNum);
        }
    }
}
