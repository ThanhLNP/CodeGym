﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EFDatabaseFirst.Models
{
    public class tblSkill
    {
        [Key]
        public int SkillID { get; set; }

        public string Title { get; set; }
    }
}