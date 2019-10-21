using Dapper;
using StudentManagement.Models.Student.Request;
using StudentManagement.Models.Student.Response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace StudentManagement.DAL
{
    public class StudentRepository : BaseRepository
    {
        public IList<Student> GetStudentList()
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                IList<Student> list = SqlMapper.Query<Student>(con, "sp_GetStudentList", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Student GetStudent(GetStudent model)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", model.Id);
                Student list = SqlMapper.Query<Student>(con, "sp_GetStudent", param: parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DeleteStudent(DeleteStudent model)
        {
            int rowAffected = 0;

            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", model.Id);
                rowAffected = SqlMapper.Execute(con, "sp_DeleteStudent", param: parameters, commandType: CommandType.StoredProcedure);
                return rowAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int AddStudent(AddStudent model)
        {
            int rowAffected = 0;

            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@LanguageId", model.LanguageId);
                parameters.Add("@LevelId", model.LevelId);
                parameters.Add("@Name", model.Name);
                parameters.Add("@DayOfBirth", model.DayOfBirth);
                parameters.Add("@Sex", model.Sex);
                parameters.Add("@Email", model.Email);
                rowAffected = SqlMapper.Execute(con, "sp_AddStudent", param: parameters, commandType: CommandType.StoredProcedure);
                return rowAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<Student> StudentSearch(StudentSearch model)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@SearchValue", model.SearchValue);
                parameters.Add("@SearchId", model.SearchId);
                IList<Student> list = SqlMapper.Query<Student>(con, "sp_StudentSearch", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateStudent(UpdateStudent model)
        {
            int rowAffected = 0;

            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", model.Id);
                parameters.Add("@LanguageId", model.LanguageId);
                parameters.Add("@LevelId", model.LevelId);
                parameters.Add("@Name", model.Name);
                parameters.Add("@DayOfBirth", model.DayOfBirth);
                parameters.Add("@Sex", model.Sex);
                parameters.Add("@Email", model.Email);
                rowAffected = SqlMapper.Execute(con, "sp_UpdateStudent", param: parameters, commandType: CommandType.StoredProcedure);
                return rowAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
