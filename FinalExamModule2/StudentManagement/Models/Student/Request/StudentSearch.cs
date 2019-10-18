using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Models.Student.Request
{
    public class StudentSearch
    {
        [Required]
        public string SearchValue { get; set; }

        [Required]
        public int SearchId { get; set; }
    }
}
