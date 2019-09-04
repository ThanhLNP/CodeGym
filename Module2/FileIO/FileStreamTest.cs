using System;
using System.IO;

namespace FileIO
{
    class FileStreamTest
    {
        public static class Helper
        {
            public static string fileName = $"D:\\code-gym\\Module2\\FileIO\\Log_{DateTime.Now.ToString("dd_MM_yyyy")}.txt";

            public static void WriteLog(string message)
            {
                FileStream file = new FileStream(fileName, FileMode.Append);
                using (StreamWriter writer = new StreamWriter(file))
                {
                    writer.WriteLine($"[Error]:{DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")}:{message}");
                }
            }

            public static string ReadLog(string fileName)
            {
                return string.Empty;
            }
        }
        static void Main(string[] args)
        {
            //FileStream fsReader = new FileStream("C:\\CodeGym\\Practices\\NetCore\\Example1\\Example1\\Text1.txt", FileMode.Open);
            //using (StreamReader reader = new StreamReader(fsReader))
            //{
            //    string line = reader.ReadToEnd();
            //    Console.WriteLine(line);
            //}

            #region TextArray
            FileStream fsArrayWriter = new FileStream("D:/code-gym/Module2/FileIO/TextArray.txt", FileMode.Append);
            using (StreamWriter arrayWriter = new StreamWriter(fsArrayWriter))
            {
                Console.Write("intput size of array: ");
                var n = int.Parse(Console.ReadLine());
                arrayWriter.WriteLine(n);
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Input A[{0}]: ", i);
                    var v = Console.ReadLine();
                    arrayWriter.Write(v.ToString() + " ");
                }
            }

            FileStream fsArrayReader = new FileStream("D:/code-gym/Module2/FileIO/TextArray.txt", FileMode.Open);
            using (StreamReader arrayReader = new StreamReader(fsArrayReader))
            {
                string line1 = arrayReader.ReadLine();
                Console.WriteLine(line1);
                string line2 = arrayReader.ReadLine();
                Console.WriteLine(line2);
                string[] arr = line2.Split(' ');
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            #endregion

            #region TextBinary
            FileStream fsBinaryWriter = new FileStream("D:\\code-gym\\Module2\\FileIO\\TextBinary.txt", FileMode.Append);
            using (BinaryWriter binaryWriter = new BinaryWriter(fsBinaryWriter))
            {
                for (int i = 0; i < 10; i++)
                {
                    binaryWriter.Write((byte)i++);
                }
            }

            FileStream fsBinaryReader = new FileStream("D:\\code-gym\\Module2\\FileIO\\TextBinary.txt", FileMode.Open);
            using (StringReader binaryReader = new StringReader("D:\\code-gym\\Module2\\FileIO\\TextBinary.txt"))
            {
                var line = binaryReader.ReadLine();
                Console.WriteLine(line);
            }
            #endregion
        }
    }
}