using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFDatabaseFirst.Models
{
    public class SkillModel
    {
        [Key]
        public int SkillID { get; set; }
        public string Title { get; set; }
    }
}
