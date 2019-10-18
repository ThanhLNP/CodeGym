using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Models.Student.Request
{
    public class AddStudent
    {
        [Display(Name = "Language")]
        [Required]
        public int LanguageId { get; set; }

        [Display(Name = "Level")]
        [Required]
        public int LevelId { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Day of birth")]
        [Required]
        public DateTime DayOfBirth { get; set; }

        [Required]
        public bool Sex { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
