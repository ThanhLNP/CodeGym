using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class BE35
    {
        static void Main()
        {
            Console.Write("Input a first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((num1 < 100 && num2 > 200) || (num1 > 200 && num2 < 100));
        }
    }
}
