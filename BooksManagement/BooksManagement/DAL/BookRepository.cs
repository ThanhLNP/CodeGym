using BooksManagement.Models.Book.Request;
using BooksManagement.Models.Book.Response;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BooksManagement.DAL
{
    public class BookRepository : BaseRepository
    {
        public IList<BooksList> GetBooksList()
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                IList<BooksList> list = SqlMapper.Query<BooksList>(con, "sp_GetBooksList", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Book GetBook(GetBook model)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", model.Id);
                Book list = SqlMapper.Query<Book>(con, "sp_GetBook", param: parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DeleteBook(DeleteBook model)
        {
            int rowAffected = 0;

            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", model.Id);
                rowAffected = SqlMapper.Execute(con, "sp_DeleteBook", param: parameters, commandType: CommandType.StoredProcedure);
                return rowAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int AddBook(AddBook model)
        {
            int rowAffected = 0;

            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@CategoryId", model.CategoryId);
                parameters.Add("@Name", model.Name);
                parameters.Add("@Author", model.Author);
                parameters.Add("@SDescription", model.SDescription);
                parameters.Add("@YearPublication", model.YearPublication);
                parameters.Add("@Amount", model.Amount);
                rowAffected = SqlMapper.Execute(con, "sp_AddBook", param: parameters, commandType: CommandType.StoredProcedure);
                return rowAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
