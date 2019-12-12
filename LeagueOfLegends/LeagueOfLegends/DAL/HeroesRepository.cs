using LeagueOfLegends.DAL.Interface;
using LeagueOfLegends.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfLegends.DAL
{
    public class HeroesRepository : IHeroesRepository
    {
        private readonly LeagueOfLegendsContext _dbContext;
        public HeroesRepository(LeagueOfLegendsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IList<GetsHeroes> GetHeroesList()
        {
            var list = new List<GetsHeroes>();

            try
            {
                list = (from h in _dbContext.Heroes
                        where h.IsDelete == false
                        select new GetsHeroes()
                        {
                            Id = h.Id,
                            Name = h.Name,
                            TypeName = (from ht in _dbContext.HeroesTypes
                                        join t in _dbContext.Types on ht.TypesId equals t.Id
                                        where ht.HeroesId == h.Id && t.IsDelete == false
                                        select t.Name).ToList()
                        }).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return list;
        }

        public GetHeroes GetHeroes(int id)
        {
            var heroes = new GetHeroes();

            try
            {
                heroes = (from h in _dbContext.Heroes
                          where h.Id == id && h.IsDelete == false
                          select new GetHeroes()
                          {
                              Id = h.Id,
                              Name = h.Name,
                              TypeName = (from ht in _dbContext.HeroesTypes
                                          join t in _dbContext.Types on ht.TypesId equals t.Id
                                          where ht.HeroesId == h.Id && t.IsDelete == false
                                          select t.Name).ToList(),
                              Health = h.Health,
                              HealthRegen = h.HealthRegen,
                              AttackDamage = h.AttackDamage,
                              Armor = h.Armor,
                              MagicResist = h.MagicResist,
                              MovementSpeed = h.MovementSpeed
                          }).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return heroes;
        }

        //    public int AddHeroes(UpdateHeroes model)
        //    {

        //    }

        //    public int UpdateHeroes(UpdateHeroes model)
        //    {

        //    }

        //    public int DeleteHeroes(int id)
        //    {
        //        var result = 0;

        //        try
        //        {
        //            var model = new Heroes() { Id = id, IsDelete = true };
        //            _dbContext.Heroes.Update(model);
        //            result = _dbContext.SaveChanges();
        //        }
        //        catch (Exception ex)
        //        {
        //            throw ex;
        //        }

        //        return result;
        //    }
    }
}
