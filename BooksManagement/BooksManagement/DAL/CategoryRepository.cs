using BooksManagement.Models.Category.Response;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BooksManagement.DAL
{
    public class CategoryRepository : BaseRepository
    {
        public IList<CategoryList> GetCategoryList()
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                IList<CategoryList> list = SqlMapper.Query<CategoryList>(con, "sp_GetCategoryList", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
