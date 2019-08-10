using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class BE05
    {
        static void Main()
        {
            int number1, number2, temp;
            Console.Write("Input the first number: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Input the second number: ");
            number2 = int.Parse(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine("After swapping: ");
            Console.WriteLine("First number: " + number1);
            Console.WriteLine("Second number: " + number2);
            Console.Read();
        }
    }
}
