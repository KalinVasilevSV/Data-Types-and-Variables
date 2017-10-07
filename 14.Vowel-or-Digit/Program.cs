using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol =char.Parse(Console.ReadLine());

            bool isVowel = "aeiou".IndexOf(symbol) >= 0;  //a method to investigate
            bool isDigit = "1234567890".IndexOf(symbol) >= 0;

            if(isVowel)
            {
                Console.WriteLine("vowel");
            }
            else if(isDigit)
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }

            //switch (symbol)
            //    {
            //        case 'a':
            //        case 'e':
            //        case 'o':
            //        case 'i':
            //        case 'u':
            //        case 'y':
            //            Console.WriteLine("vowel");
            //            break;
            //        case '1':
            //        case '2':
            //        case '3':
            //        case '4':
            //        case '5':
            //        case '6':
            //        case '7':
            //        case '8':
            //        case '9':
            //        case '0':
            //            Console.WriteLine("digit");
            //            break;
            //        default:
            //            Console.WriteLine("other");
            //            break;
            //    }

        }
    }
}
