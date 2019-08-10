using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class BE15
    {
        static void Main()
        {
            Console.Write("Enter non-empty string: ");
            string str = Console.ReadLine();
            Console.Write("Enter remove index: ");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine(removeChar(str, i));
        }

        public static string removeChar(string str, int i)
        {
            return str.Remove(i, 1);
        }
    }
}
