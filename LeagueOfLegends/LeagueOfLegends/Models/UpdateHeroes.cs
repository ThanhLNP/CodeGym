using System.Collections.Generic;

namespace LeagueOfLegends.Models
{
    public class UpdateHeroes
    {
        public int Id { get; set; }
        public List<int> TypeID { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public int HealthRegen { get; set; }
        public int AttackDamage { get; set; }
        public int Armor { get; set; }
        public int MagicResist { get; set; }
        public int MovementSpeed { get; set; }
    }
}
