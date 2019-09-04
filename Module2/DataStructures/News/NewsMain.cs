using System;
using System.Collections;

namespace DataStructures.News
{
    class NewsMain
    {
        static int id;
        static ArrayList newsList = new ArrayList();
        public static void Main()
        {
            InitMenu();
        }

        public static void InitMenu()
        {
            int option = 0;

            do
            {
                Console.WriteLine("Management News");
                Console.WriteLine("1. Insert news");
                Console.WriteLine("2. View list news");
                Console.WriteLine("3. Average rate");
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
                    InsertNews();
                    break;
                case 2:
                    ViewList();
                    break;
                case 3:
                    CalculateNews();
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

        public static void InsertNews()
        {
            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Publish date: ");
            string publishDate = Console.ReadLine();

            Console.Write("Author: ");
            string author = Console.ReadLine();

            Console.Write("Content: ");
            string content = Console.ReadLine();

            int[] rateList = new int[3];
            for(int i =0; i < rateList.Length; i++)
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

            News news = new News(id, title, publishDate, author, content, rateList);
            newsList.Add(news);

            id++;
        }

        public static void ViewList()
        {
            foreach(News news in newsList)
            {
                news.Display();
            }
        }

        public static void CalculateNews()
        {
            foreach (News news in newsList)
            {
                news.Calculate();
                news.Display();
            }
        }
    }
}