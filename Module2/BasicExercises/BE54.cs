using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class BE54
    {
        static void Main()
        {
            Console.Write("Enter a year: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Century: " + centuryFromYear(y));
        }
        public static int centuryFromYear(int year)
        {
            return (int)(year / 100) + ((year % 100 == 0) ? 0 : 1);
        }
    }
}
