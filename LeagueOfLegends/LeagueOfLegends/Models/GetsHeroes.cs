using System.Collections.Generic;

namespace LeagueOfLegends.Models
{
    public class GetsHeroes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> TypeName { get; set; }
        public string TypeNameStr => TypeName != null ? string.Join(", ", TypeName) : string.Empty;
    }
}
