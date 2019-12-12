using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeagueOfLegends.Models
{
    public class Types
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Column("isDelete")]
        public bool IsDelete { get; set; } = false;

        public virtual ICollection<HeroesTypes> HeroesTypes { get; set; }
    }
}
