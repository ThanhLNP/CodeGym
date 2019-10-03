using DAL;
using Domain;
using System.Collections.Generic;

namespace BAL
{
    public class PhongBanService
    {
        PhongBanRepository _phongBanRepository;
        public PhongBanService(PhongBanRepository phongBanRepository)
        {
            _phongBanRepository = phongBanRepository;
        }

        public bool CreatePhongBan(PhongBan phongBan)
        {
            return _phongBanRepository.CreatePhongBan(phongBan);
        }

        public bool DeletePhongBan(int ID)
        {
            return _phongBanRepository.DeletePhongBan(ID);
        }

        public IList<PhongBanView> GetAllPhongBan()
        {
            return _phongBanRepository.GetAllPhongBan();
        }

        public PhongBanView GetPhongBanByID(int ID)
        {
            return _phongBanRepository.GetPhongBanByID(ID);
        }

        public bool UpdatePhongBan(PhongBan phongBan)
        {
            return _phongBanRepository.UpdatePhongBan(phongBan);
        }
    }
}
