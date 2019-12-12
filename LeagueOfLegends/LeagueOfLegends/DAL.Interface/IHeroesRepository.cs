using LeagueOfLegends.Models;
using System.Collections.Generic;

namespace LeagueOfLegends.DAL.Interface
{
    public interface IHeroesRepository
    {
        IList<GetsHeroes> GetHeroesList();
        GetHeroes GetHeroes(int id);
        //int AddHeroes(UpdateHeroes model);
        //int UpdateHeroes(UpdateHeroes model);
        //int DeleteHeroes(int id);
    }
}
