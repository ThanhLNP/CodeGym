using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace BasicExercises
{
    class BE30
    {
        static void Main()
        {
            string hexval = "     4B0";
            Console.WriteLine("Hexadecimal number: " + hexval);
            int decValue = int.Parse(hexval, NumberStyles.HexNumber);
            Console.WriteLine("Convert to - Decimal number: " + decValue);
        }
    }
}
