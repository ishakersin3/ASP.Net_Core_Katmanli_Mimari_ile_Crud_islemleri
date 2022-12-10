using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace Product_Demo.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen İsim Giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen Soyisim Giriniz")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Lütfen Kullanıcı Adı Giriniz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen Email Adresi Giriniz")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Lütfen Şifre Giriniz")]
        public string Password { get; set; }
        [Required]
        [Compare("Password",ErrorMessage ="Lütfen Şifrelerin Eşleştiğinden Emin Ol")]
        public string ConfirmPassword { get; set; }       
    }
}
