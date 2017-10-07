using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string fittingTypes = string.Empty;

            try
            {
                sbyte signedByte = sbyte.Parse(input);
                fittingTypes += "* sbyte \n";
            }
            catch{ }

            try
            {
                byte unsignedByte = byte.Parse(input);
                fittingTypes += "* byte \n";
            }
            catch{ }

            try
            {
                short signedShort = short.Parse(input);
                fittingTypes += "* short \n";
            }
            catch { }

            try
            {
                ushort unsignedShort = ushort.Parse(input);
                fittingTypes += "* ushort \n";
            }
            catch { }

            try
            {
                int signedInt = int.Parse(input);
                fittingTypes += "* int \n";
            }
            catch { }

            try
            {
                uint unsignedInt = uint.Parse(input);
                fittingTypes += "* uint \n";
            }
            catch { }

            try
            {
                long signedLong = long.Parse(input);
                fittingTypes += "* long \n";
            }
            catch { }

            //try
            //{
            //    ulong unsignedLong = ulong.Parse(input);
            //    fittingTypes += "* ulong \n";
            //}
            //catch { }

            //try
            //{
            //    float typeFloat = float.Parse(input);
            //    fittingTypes += "* float \n";
            //}
            //catch { }

            //try
            //{
            //    double typeDouble = double.Parse(input);
            //    fittingTypes += "* double \n";
            //}
            //catch { }

            //try
            //{
            //    decimal typeDecimal = decimal.Parse(input);
            //    fittingTypes += "* decimal \n";
            //}
            //catch { }

            if (fittingTypes == string.Empty)
            {
                Console.WriteLine($"{input} can't fit in any type");
            }
            else
            {
                Console.WriteLine($"{input} can fit in:");
                Console.WriteLine(fittingTypes);
            }
        }
    }
}

