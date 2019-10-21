using Dapper;
using StudentManagement.Models.Level.Request;
using StudentManagement.Models.Level.Response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace StudentManagement.DAL
{
    public class LevelRepository : BaseRepository
    {
        public IList<LevelList> GetLevelList(GetLevelList model)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@LanguageId", model.LanguageId);
                IList<LevelList> list = SqlMapper.Query<LevelList>(con, "sp_GetLevelList", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<AllLevel> GetAllLevel()
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                IList<AllLevel> list = SqlMapper.Query<AllLevel>(con, "sp_GetAllLevel", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
