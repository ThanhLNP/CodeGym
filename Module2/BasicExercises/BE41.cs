using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicExercises
{
    class BE41
    {
        static void Main()
        {
            Console.Write("Input a string: ");
            string str = Console.ReadLine();
            var count = str.Count(s => s == 'w'); //Linq & Lambda 
            Console.WriteLine("Test the string contains 'w' character  between 1 and 3 times: ");
            Console.WriteLine(count >= 1 && count <= 3);
        }
    }
}
