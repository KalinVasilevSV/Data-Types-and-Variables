using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Strings_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = Console.ReadLine(); //Input in task is "Hello" hence the naming
            string world = Console.ReadLine(); //Input in task is "World" hence the naming

            object concatenation = hello + " " + world;

            string helloWorld =(string)concatenation;

            Console.WriteLine(helloWorld);
        }
    }
}
