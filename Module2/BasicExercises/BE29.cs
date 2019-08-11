using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BasicExercises
{
    class BE29
    {
        static void Main()
        {
            FileInfo f = new FileInfo("D:/code-gym/Module2/BasicExercises/BE28.cs");
            Console.WriteLine("Size of a file: " + f.Length);
        }
    }
}
