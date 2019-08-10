using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class BE09
    {
        static void Main()
        {
            Console.Write("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            double num3 = double.Parse(Console.ReadLine());
            Console.Write("Enter the four number: ");
            double num4 = double.Parse(Console.ReadLine());
            double average = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("The average of {0}, {1}, {2}, {3} is : {4}", num1, num2, num3, num4, average);
        }
    }
}
