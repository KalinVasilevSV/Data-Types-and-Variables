using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Thea_the_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong picturesTaken = ulong.Parse(Console.ReadLine());
            ulong filterTimePerPic = ulong.Parse(Console.ReadLine());
            float filterFactorPercentage = float.Parse(Console.ReadLine());
            ulong uploadTimePerPic = ulong.Parse(Console.ReadLine());

            ulong filterTimeTotal = filterTimePerPic * picturesTaken;

            uint picsToUpload = (uint)Math.Ceiling(picturesTaken * (filterFactorPercentage/100));

            ulong uploadTimeTotal = picsToUpload * uploadTimePerPic;

            ulong totalTime = filterTimeTotal + uploadTimeTotal;

            ulong days = totalTime / (24 * 60 * 60);

            ulong remainingTime = totalTime % (24 * 60 * 60);

            ulong hours = remainingTime / (60 * 60);
            remainingTime = remainingTime % (60 * 60);

            ulong minutes = remainingTime / 60;
            remainingTime = remainingTime % 60;

            ulong seconds = remainingTime;

            Console.WriteLine($"{days:D1}:{hours:D2}:{minutes:D2}:{seconds:D2}");
        }
    }
}
