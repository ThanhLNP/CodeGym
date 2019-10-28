using System.ComponentModel.DataAnnotations;

namespace UsingAJAX.Context
{
    public class Student
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }
    }
}
