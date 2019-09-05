using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    class Post : IPost
    {
        private int id;
        private string title;
        private string content;
        private string author;
        private float averageRate;
        private int[] rates = new int[4];

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public string Author { get => author; set => author = value; }
        public float AverageRate { get => averageRate; }
        public int[] Rates { get => rates; set => rates = value; }

        public Post()
        {

        }

        public Post(int id, string title, string content, string author, int[] rateList)
        {
            Id = id;
            Title = title;
            Content = content;
            Author = author;
            Rates = rateList;
        }

        public void Display()
        {
            Console.WriteLine("ID: {0}, Title: {1}, Content: {2}, Author: {3}, Average rate: {4}", id, title, content, author, averageRate);
        }

        public void CalculatorRate()
        {
            foreach (int element in rates)
            {
                averageRate += element;
            }

            averageRate /= rates.Length;
        }
    }
}
