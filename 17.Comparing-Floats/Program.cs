using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Comparing_Floats
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());

            var epsilon = 0.000001;

            var diff = Math.Abs(a - b);


            bool isEqual = false;

            if (diff < epsilon)
            {
                isEqual = true;
            }

            Console.WriteLine(isEqual);

        }
    }
}
