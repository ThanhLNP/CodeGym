using LeagueOfLegends.DAL.Interface;
using LeagueOfLegends.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeagueOfLegends.DAL
{
    public class TypesRepository : ITypesRepository
    {
        private readonly LeagueOfLegendsContext _dbContext;
        public TypesRepository(LeagueOfLegendsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IList<Types> GetTypesList()
        {
            var list = new List<Types>();

            try
            {
                list = (from t in _dbContext.Types
                        where t.IsDelete == false
                        select t).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return list;
        }

        public int AddTypes(Types model)
        {
            var result = 0;

            try
            {
                var isUnique = (from t in _dbContext.Types
                                where t.Name.Contains(model.Name) && t.IsDelete == false
                                select t).ToList();

                if (isUnique.Count() > 0)
                {
                    return result;
                }
                else
                {
                    _dbContext.Types.Add(model);
                    _dbContext.SaveChanges();
                    result = model.Id;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public int UpdateTypes(Types model)
        {
            var result = 0;

            try
            {
                var isUnique = (from t in _dbContext.Types
                                where t.Name.Contains(model.Name) && t.IsDelete == false
                                select t).ToList();

                if (isUnique.Count() > 0)
                {
                    return result;
                }
                else
                {
                    _dbContext.Types.Update(model);
                    result = _dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public int DeleteTypes(int id)
        {
            var result = 0;

            try
            {
                var model = _dbContext.Types.FirstOrDefault(t => t.Id == id);
                model.IsDelete = true;

                _dbContext.Types.Update(model);
                result = _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }
    }
}
