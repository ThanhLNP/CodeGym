using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class BE37
    {
        static void Main()
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine();
            Console.WriteLine(str.Substring(1, 2).Equals("HP") ? str.Remove(1, 2) : str);
        }
    }
}
