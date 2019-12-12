using System.Collections.Generic;

namespace LeagueOfLegends.Models
{
    public class GetHeroes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> TypeName { get; set; }
        public string TypeNameStr => TypeName != null ? string.Join(", ", TypeName) : string.Empty;
        public int Health { get; set; }
        public int HealthRegen { get; set; }
        public int AttackDamage { get; set; }
        public int Armor { get; set; }
        public int MagicResist { get; set; }
        public int MovementSpeed { get; set; }
    }
}
