using Dapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DAL
{
    public class PhongBanRepository : BaseRepository
    {
        public bool CreatePhongBan(PhongBan phongBan)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@MaPB", phongBan.MaPB);
                parameters.Add("@TenPB", phongBan.TenPB);
                SqlMapper.Execute(con, "CreatePhongBan", param: parameters, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeletePhongBan(int ID)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ID", ID);
            SqlMapper.Execute(con, "DeletePhongBan", param: parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public IList<PhongBanView> GetAllPhongBan()
        {
            IList<PhongBanView> customerList = SqlMapper.Query<PhongBanView>(con, "GetAllPhongBan", commandType: CommandType.StoredProcedure).ToList();
            return customerList;
        }

        public PhongBanView GetPhongBanByID(int ID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", ID);
                return SqlMapper.Query<PhongBanView>((SqlConnection)con, "GetPhongBanByID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool UpdatePhongBan(PhongBan phongBan)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", phongBan.ID);
                parameters.Add("@MaPB", phongBan.MaPB);
                parameters.Add("@TenPB", phongBan.TenPB);
                SqlMapper.Execute(con, "UpdatePhongBan", param: parameters, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
