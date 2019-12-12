namespace LeagueOfLegends.Models
{
    public class HeroesTypes
    {
        public int TypesId { get; set; }
        public virtual Types Types { get; set; }

        public int HeroesId { get; set; }
        public virtual Heroes Heroes { get; set; }

    }
}
