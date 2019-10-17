using System.ComponentModel.DataAnnotations;

namespace BooksManagement.Models.Book.Response
{
    public class Book
    {
        public int Id { get; set; }

        [Display(Name = "Categories")]
        public string CategoryName { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        [Display(Name = "Description")]
        public string SDescription { get; set; }

        [Display(Name = "Year of publication")]
        public int YearPublication { get; set; }

        public int Amount { get; set; }
    }
}
