using DAL;
using Domain;
using System.Collections.Generic;
using System.Linq;

namespace BAL
{
    public class NhanVienService
    {
        NhanVienRepository _nhanVienRepository;
        public NhanVienService(NhanVienRepository nhanVienRepository)
        {
            _nhanVienRepository = nhanVienRepository;
        }

        public bool CreateNhanVien(NhanVien nhanVien)
        {
            return _nhanVienRepository.CreateNhanVien(nhanVien);
        }

        public bool DeleteNhanVien(int MaNV)
        {
            return _nhanVienRepository.DeleteNhanVien(MaNV);
        }

        public IEnumerable<NhanVien> GetAllNhanVien(int ID)
        {
            var listNhanVien = _nhanVienRepository.GetAllNhanVien();
            IEnumerable<NhanVien> query = listNhanVien.Where(nhanVien => nhanVien.IDPB == ID);
            return query;
        }

        public NhanVien GetNhanVienByMaNV(int MaNV)
        {
            return _nhanVienRepository.GetNhanVienByMaNV(MaNV);
        }

        public bool UpdateNhanVien(NhanVien nhanVien)
        {
            return _nhanVienRepository.UpdateNhanVien(nhanVien);
        }
    }
}
