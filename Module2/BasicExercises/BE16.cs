using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class BE16
    {
        static void Main()
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine();
            Console.WriteLine(changeFirstLast(str));
        }

        public static string changeFirstLast(string ustr)
        {
            return ustr.Length > 1
                ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr;
        }
    }
}
