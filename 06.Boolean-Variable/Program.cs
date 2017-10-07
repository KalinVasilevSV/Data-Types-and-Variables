using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();


            bool isTrue = str == "True";
            bool isFalse = str == "False";

            if (isTrue)
            {
                Console.WriteLine("Yes");
            }
            else if (isFalse)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            // Solution suggested by exercise hints, throws exception when input other than "True" or "False"

            //bool isTrue = Convert.ToBoolean(str);

            //if(isTrue)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else if(!isTrue)
            //{
            //    Console.WriteLine("No");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //}

        }
    }
}
