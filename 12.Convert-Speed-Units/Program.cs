using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            float timeInSeconds = hours * 60 * 60 + minutes * 60 + seconds;

            float speedMPS = distance / timeInSeconds;
            float speedKPH = speedMPS * 3.6f;
            float speedMPH = speedKPH* 0.6215041f; //needs work

            Console.WriteLine(speedMPS);
            Console.WriteLine(speedKPH);
            Console.WriteLine(speedMPH);
        }
    }
}
