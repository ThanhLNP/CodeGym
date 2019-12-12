using LeagueOfLegends.Models;
using System.Collections.Generic;

namespace LeagueOfLegends.DAL.Interface
{
    public interface ITypesRepository
    {
        IList<Types> GetTypesList();
        int AddTypes(Types model);
        int UpdateTypes(Types model);
        int DeleteTypes(int id);
    }
}
