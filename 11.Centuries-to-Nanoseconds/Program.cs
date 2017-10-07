using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _11.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;
            int days = (int)(years*365.2422);
            long hours = days * 24;
            long minutes = hours * 60;
            ulong seconds = (ulong)minutes * 60;
            ulong milliseconds = seconds * 1000;
            ulong microseconds = milliseconds * 1000;
            BigInteger nanoseconds = BigInteger.Multiply(microseconds,1000);

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
            
            //Console.WriteLine(years);
            //Console.WriteLine(days);
            //Console.WriteLine(hours);
            //Console.WriteLine(minutes);
            //Console.WriteLine(seconds);
            //Console.WriteLine(miliseconds);
            //Console.WriteLine(microseconds);
            //Console.WriteLine(nanoseconds);
        }
    }
}
