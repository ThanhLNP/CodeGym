using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class BE44
    {
        static void Main()
        {
            Console.Write("Input a string: ");
            string str = Console.ReadLine();
            string result = "";
            for (var i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0) result += str[i];
            }
            Console.WriteLine(result);
        }
    }
}
