using Dapper;
using StudentManagement.Models.Language.Response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace StudentManagement.DAL
{
    public class LanguageRepository : BaseRepository
    {
        public IList<LanguageList> GetLanguageList()
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                IList<LanguageList> list = SqlMapper.Query<LanguageList>(con, "sp_GetLanguageList", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
