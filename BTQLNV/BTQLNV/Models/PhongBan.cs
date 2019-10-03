using System.ComponentModel.DataAnnotations;

namespace BTQLNV.Models
{
    public class PhongBan
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập ma phong ban")]
        [StringLength(5, ErrorMessage = "Bạn phải nhập khong qua 5 ky tu")]
        public string MaPB { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập ten phong ban")]
        [StringLength(50, ErrorMessage = "Bạn phải nhập khong qua 50 ky tu")]
        public string TenPB { get; set; }
        public bool isDelete { get; set; }
    }
}
