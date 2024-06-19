using System.ComponentModel.DataAnnotations;
public enum UserRole
{
    Customer, // Khách hàng
    Admin // Admin
}
namespace ClotherAPI.Models
{
    public class User
    {
        // info user
        [Key]
        public string userId { get; set; }
        [Required(ErrorMessage = "Tên người dùng không được để trống.")]
        public string userName { get; set; }
        [EmailAddress(ErrorMessage = "Email không đúng định dạng.")]
        public string email { get; set; }
        [Required(ErrorMessage = "Mật khẩu không được để trống.")]
        public string password { get; set; }
        public int verified { get; set; }
        public string resetToken { get; set; }

        public UserRole role { get; set; }
        public string avatar { get; set; } = "https://as1.ftcdn.net/v2/jpg/03/46/83/96/1000_F_346839683_6nAPzbhpSkIpb8pmAwufkC7c5eD7wYws.jpg";
        [Required(ErrorMessage = "Số điện thoại không được để trống.")]
        public string phoneNumber { get; set; }
        public string dateOfBirth { get; set; }
    }
}
