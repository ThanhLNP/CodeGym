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
        private double averageRate;

        protected int Id { get => id; set => id = value; }
        protected string Title { get => title; set => title = value; }
        protected string PublishDate { get => publishDate; set => publishDate = value; }
        protected string Author { get => author; set => author = value; }
        protected string Content { get => content; set => content = value; }
        protected double AverageRate { get => averageRate; }

        public void Display()
        {

        }
    }
}
