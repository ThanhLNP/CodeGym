using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeagueOfLegends.Models
{
    public class Heroes
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public int Health { get; set; }
        public int HealthRegen { get; set; }
        public int AttackDamage { get; set; }
        public int Armor { get; set; }
        public int MagicResist { get; set; }
        public int MovementSpeed { get; set; }

        [Column("isDelete")]
        public bool IsDelete { get; set; } = false;

        public virtual ICollection<HeroesTypes> HeroesTypes { get; set; }
    }
}
