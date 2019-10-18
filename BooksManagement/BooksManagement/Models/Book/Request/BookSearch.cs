using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BooksManagement.Models.Book.Request
{
    public class BookSearch
    {
        public string SearchValue { get; set; }
        public int SearchId { get; set; }
    }
}
