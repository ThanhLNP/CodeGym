using System;
using System.Collections.Generic;

namespace Exam
{
    class Forum
    {
        static int id;
        static List<Post> PostList = new List<Post>();
        public static void Main()
        {
            InitMenu();
        }

        public static void InitMenu()
        {
            int option = 0;

            do
            {
                Console.WriteLine("Management Post");
                Console.WriteLine("1. Create Post");
                Console.WriteLine("2. Calculator");
                Console.WriteLine("3. Show list");
                Console.WriteLine("4. Exit");

                Console.Write("Please select an option from 1 to 4: ");
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    option = number;
                }

                Console.WriteLine("\n********************");
            }
            while (option < 1 || option > 4);

            Process(option);
        }

        public static void Process(int selected)
        {
            Console.WriteLine("Option: {0}", selected);

            switch (selected)
            {
                case 1:
                    CreatePost();
                    break;
                case 2:
                    Calculator();
                    break;
                case 3:
                    ShowList();
                    break;
                case 4:
                    {
                        Console.WriteLine("Exit");
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }
            }

            Console.WriteLine("\n********************");

            InitMenu();
        }

        public static void CreatePost()
        {
            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Content: ");
            string content = Console.ReadLine();

            Console.Write("Author: ");
            string author = Console.ReadLine();

            int[] rateList = new int[4];
            for (int i = 0; i < rateList.Length; i++)
            {
                do
                {
                    Console.Write("Nhap danh gia lan {0}: ", i + 1);
                    if (int.TryParse(Console.ReadLine(), out var number))
                    {
                        rateList[i] = number;
                    }
                }
                while (rateList[i] < 1 || rateList[i] > 10);
            }

            Post post = new Post(id, title, content, author, rateList);
            PostList.Add(post);

            id++;
        }

        public static void Calculator()
        {
            foreach (Post post in PostList)
            {
                post.CalculatorRate();
                post.Display();
            }
        }

        public static void ShowList()
        {
            foreach (Post post in PostList)
            {
                post.Display();
            }
        }
    }
}
