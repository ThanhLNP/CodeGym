using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class BE28
    {
        static void Main()
        {
            string line = "Display the pattern like pyramid using the alphabet.";
            Console.WriteLine("Original String: " + line);
            string result = "";
            string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
            for (int i = words.Length - 1; i >= 0; i--)
            {
                result += words[i] + " ";
            }
            Console.WriteLine("Reverse String: " + result);
        }
    }
}
