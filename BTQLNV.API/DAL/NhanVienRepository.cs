using Dapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

namespace DAL
{
    public class NhanVienRepository : BaseRepository
    {
        public bool CreateNhanVien(NhanVien nhanVien)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDPB", nhanVien.IDPB);
                parameters.Add("@Ho", nhanVien.Ho);
                parameters.Add("@Ten", nhanVien.Ten);
                parameters.Add("@DiaChi", nhanVien.DiaChi);
                parameters.Add("@DienThoai", nhanVien.DienThoai);
                parameters.Add("@Email", nhanVien.Email);
                SqlMapper.Execute(con, "CreateNhanVien", param: parameters, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteNhanVien(int MaNV)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@MaNV", MaNV);
            SqlMapper.Execute(con, "DeleteNhanVien", param: parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public IList<NhanVien> GetAllNhanVien()
        {
            IList <NhanVien> customerList = SqlMapper.Query<NhanVien>(con, "GetAllNhanVien", commandType: CommandType.StoredProcedure).ToList();
            return customerList;
        }

        public NhanVien GetNhanVienByMaNV(int MaNV)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@MaNV", MaNV);
                return SqlMapper.Query<NhanVien>((SqlConnection)con, "GetNhanVienByMaNV", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool UpdateNhanVien(NhanVien nhanVien)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@MaNV", nhanVien.MaNV);
                parameters.Add("@IDPB", nhanVien.IDPB);
                parameters.Add("@Ho", nhanVien.Ho);
                parameters.Add("@Ten", nhanVien.Ten);
                parameters.Add("@DiaChi", nhanVien.DiaChi);
                parameters.Add("@DienThoai", nhanVien.DienThoai);
                parameters.Add("@Email", nhanVien.Email);
                SqlMapper.Execute(con, "UpdateNhanVien", param: parameters, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
