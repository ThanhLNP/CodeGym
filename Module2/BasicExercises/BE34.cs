using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class BE34
    {
        static void Main()
        {
            Console.Write("Input a string : ");
            string str = Console.ReadLine();
            Console.Write("Input specified word: ");
            string spe_word = Console.ReadLine();
            Console.WriteLine(str.StartsWith(spe_word) && str[5] == ' ');
        }
    }
}
