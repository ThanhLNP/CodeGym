using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class BE38
    {
        static void Main()
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine();
            Console.WriteLine(str.Substring(0, 2).Equals("PH") ? str.Substring(0, 2) : str);
        }
    }
}
