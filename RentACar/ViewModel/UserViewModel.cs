using System.ComponentModel.DataAnnotations;

namespace RentACar.ViewModel
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "{0} Gerekli"), Display(Name = "E-Posta"), 
            StringLength(50, MinimumLength = 6, ErrorMessage = "{0},{2}-{1} Karakter olmalı."),
            DataType(DataType.EmailAddress, ErrorMessage = "{0} Uygun formatta değil")]
        public string Email { get; set; }
        [Required(ErrorMessage = "{0} Gerekli"), Display(Name = "Şifre"),
            StringLength(20, MinimumLength = 6, ErrorMessage = "{0},{2}-{1} Karakter olmalı."), 
            DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
