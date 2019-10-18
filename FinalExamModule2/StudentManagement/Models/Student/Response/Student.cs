using System;
using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Models.Student.Response
{
    public class Student
    {
        public int Id { get; set; }

        [Display(Name = "Language")]
        public int LanguageName { get; set; }

        [Display(Name = "Level")]
        public int LevelName { get; set; }

        public string Name { get; set; }

        [Display(Name = "Day of birth")]
        public DateTime DayOfBirth { get; set; }

        public bool Sex { get; set; }

        public string Email { get; set; }
    }
}
