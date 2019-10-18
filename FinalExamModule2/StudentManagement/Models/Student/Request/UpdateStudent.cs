using System;
using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Models.Student.Request
{
    public class UpdateStudent
    {
        public int Id { get; set; }

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
