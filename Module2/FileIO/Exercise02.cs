using System;
using System.IO;

namespace FileIO
{
    class Exercise02
    {
        public static void Main()
        {
            #region Output Array
            FileStream fsWrite = new FileStream("D:/code-gym/Module2/FileIO/ArrInput.txt", FileMode.Create);
            using (StreamWriter write = new StreamWriter(fsWrite))
            {
                int size = -1;
                do
                {
                    Console.Write("Intput size of array: ");
                    if (int.TryParse(Console.ReadLine(), out var number))
                    {
                        size = number;
                    }
                }
                while (size < 0);

                write.WriteLine(size);

                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        do
                        {
                            Console.Write("Input A[{0}, {1}]: ", i, j);
                            if (int.TryParse(Console.ReadLine(), out var number))
                            {
                                int v = number;
                                write.Write(v + " ");
                                break;
                            }
                        }
                        while (true);
                    }
                    write.WriteLine();
                }
            }
            fsWrite.Close();
            #endregion
        }

    }
}
