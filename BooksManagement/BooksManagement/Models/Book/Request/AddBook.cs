using System.ComponentModel.DataAnnotations;

namespace BooksManagement.Models.Book.Request
{
    public class AddBook
    {
        [Display(Name = "Categories")]
        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Author { get; set; }

        [Display(Name = "Description")]
        public string SDescription { get; set; }

        [Display(Name = "Year of publication")]
        [Required]
        public int YearPublication { get; set; }

        [Required]
        public int Amount { get; set; }
    }
}
