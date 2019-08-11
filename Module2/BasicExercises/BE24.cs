using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class BE24
    {
        static void Main()
        {
            Console.Write("Enter string: ");
            string line = Console.ReadLine();
            string[] arr_word = line.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int ctr = 0;
            foreach (String s in arr_word)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }

            Console.WriteLine(word);
        }
    }
}
