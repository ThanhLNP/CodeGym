using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.News
{
    class News : INews
    {
        private int id;
        private string title;
        private string publishDate;
        private string author;
        private string content;
        private float averageRate;
        private int[] rateList = new int[3];

        protected int Id { get => id; set => id = value; }
        protected string Title { get => title; set => title = value; }
        protected string PublishDate { get => publishDate; set => publishDate = value; }
        protected string Author { get => author; set => author = value; }
        protected string Content { get => content; set => content = value; }
        protected float AverageRate { get => averageRate; }

        public void Display()
        {
            Console.WriteLine("{0} {1} {2} {3} {4}", title, publishDate, author, content, averageRate);
        }

        public void Calculate()
        {
            foreach(int element in rateList)
            {
                averageRate += element;
            }

            averageRate /= rateList.Length;
        }
    }
}
