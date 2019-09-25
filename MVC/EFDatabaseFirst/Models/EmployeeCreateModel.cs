using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFDatabaseFirst.Models
{
    public class EmployeeCreateModel
    {
        [Key]
        public int EmployeeID { get; set; }

        [Display(Name = "Employee Name")]
        [Required(ErrorMessage = "Bạn phải nhập tên nhân viên")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Bạn phải nhập lớn hơn 1 kí tự")]
        public string EmployeeName { get; set; }

        [Display(Name = "Contact Number")]
        [Required(ErrorMessage = "Bạn phải nhập số điện thoại")]
        [RegularExpression(pattern: "(09|01[2689]){1}([0-9]{8})", ErrorMessage = "Số điện thoại không đúng định dạng")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Your Skill")]
        public int SkillID { get; set; }

        [Display(Name = "Years of Experience")]
        [Required(ErrorMessage = "Bạn phải nhập số năm kinh nghiệm")]
        [Range(minimum: 0, maximum: 50, ErrorMessage = "Bạn phải nhập năm kinh nghiệm từ 0 đến 50")]
        public int YearsExperience { get; set; }
    }
}
