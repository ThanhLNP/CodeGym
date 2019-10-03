using System.ComponentModel.DataAnnotations;

namespace BTQLNV.Models
{
    public class NhanVien
    {
        public int MaNV { get; set; }

        [Display(Name = "Phong ban")]
        public int IDPB { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập ho")]
        [StringLength(20, ErrorMessage = "Bạn phải nhập khong qua 20 ky tu")]
        public string Ho { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập ten")]
        [StringLength(20, ErrorMessage = "Bạn phải nhập khong qua 20 ky tu")]
        public string Ten { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập dia chi")]
        [StringLength(20, ErrorMessage = "Bạn phải nhập khong qua 250 ky tu")]
        public string DiaChi { get; set; }

        [Phone(ErrorMessage = "Invalid Phone number")]
        public string DienThoai { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }
        public bool isDelete { get; set; }
    }
}
