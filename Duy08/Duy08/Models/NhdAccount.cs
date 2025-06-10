using System.ComponentModel.DataAnnotations;

namespace Duy08.Models
{
    public class Account
    {
        [Key]
        public int NhdId { get; set; }

        [Display(Name = "Mã sinh viên")]
        [Required(ErrorMessage = "Mã sinh viên không được để trống")]
        public string NhdMaSinhVien { get; set; }

        [Display(Name = "Họ và Tên")]
        [Required(ErrorMessage = "Họ và tên không được để trống")]
        [MinLength(6, ErrorMessage = "Họ tên tối thiểu 6 ký tự")]
        [MaxLength(28, ErrorMessage = "Họ tên tối đa 28 ký tự")]
        public string NhdHoVaTen { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email không được để trống")]
        [EmailAddress(ErrorMessage = "Email không đúng định dạng")]
        public string NhdEmail { get; set; }

        [Display(Name = "Điện thoại")]
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [Phone(ErrorMessage = "Số điện thoại không đúng định dạng")]
        public string NhdDienThoai { get; set; }

        [Display(Name = "Địa chỉ")]
        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        [StringLength(35, ErrorMessage = "Địa chỉ tối đa 35 ký tự")]
        public string NhdDiaChi { get; set; }

        [Display(Name = "Ảnh đại diện")]
        public string NhdAnhDaiDien { get; set; }

        [Display(Name = "Ngày sinh")]
        [Required(ErrorMessage = "Ngày sinh không được để trống")]
        [DataType(DataType.Date)]
        public DateTime NhdNgaySinh { get; set; }

        [Display(Name = "Giới tính")]
        public string NhdGioiTinh { get; set; }

        [Display(Name = "Mật khẩu")]
        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [DataType(DataType.Password)]
        public string NhdMatKhau { get; set; }

        [Display(Name = "Link Facebook")]
        [Required(ErrorMessage = "Facebook không được để trống")]
        [Url(ErrorMessage = "Đường dẫn Facebook không đúng định dạng (phải bắt đầu bằng http hoặc https)")]
        public string NhdFacebook { get; set; }
    }
}
