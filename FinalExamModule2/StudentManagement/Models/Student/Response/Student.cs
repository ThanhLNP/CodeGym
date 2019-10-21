using System;
using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Models.Student.Response
{
    public class Student
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        [Display(Name = "Language")]
        public string LanguageName { get; set; }
        public int LevelId { get; set; }
        [Display(Name = "Level")]
        public string LevelName { get; set; }

        public string Name { get; set; }

        [Display(Name = "Day of birth")]
        [DataType(DataType.Date)]
        public DateTime DayOfBirth { get; set; }

        public bool Sex { get; set; }
        public string SexStr => Sex ? "Male" : "Female";

        public string Email { get; set; }
    }
}
