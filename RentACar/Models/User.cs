using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentACar.Models
{
    public class User
    {


        [Key]
        public int UserID { get; set; }


        [Required(ErrorMessage = "{0} Gerekli"), Display(Name = "E-Posta"), StringLength(50, MinimumLength = 6, ErrorMessage = "{0},{2}-{1} Karakter olmalı."), DataType(DataType.EmailAddress, ErrorMessage = "{0} Uygun formatta değil")]
        public string Email { get; set; }



        [Required(ErrorMessage = "{0} Gerekli"), Display(Name = "Şifre"), StringLength(20, MinimumLength = 6, ErrorMessage = "{0},{2}-{1} Karakter olmalı."), DataType(DataType.Password)]
        public string Password { get; set; }

        [NotMapped, Display(Name = "Şifre Tekrarı"), DataType(DataType.Password), Compare("Passwordd", ErrorMessage = "Şifreler eşleşmedi.")]
        public string PasswordRepeat { get; set; }

        [Required(ErrorMessage = "{0} Gerekli"), Display(Name = "Adı ve varsa ikinci adı"), StringLength(40, MinimumLength = 2, ErrorMessage = "{0},{2}-{1} Karakter olmalı.")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "{0} Gerekli"), Display(Name = "Soyadı"), StringLength(20, MinimumLength = 2, ErrorMessage = "{0},{2}-{1} Karakter olmalı.")]
        public string Surname { get; set; }
     

        [Required(ErrorMessage = "{0} Gerekli"), Display(Name = "GSM No"), StringLength(15, MinimumLength = 10, ErrorMessage = "{0},{2}-{1} Karakter olmalı."), DataType(DataType.PhoneNumber, ErrorMessage = "{0} uygun formatta değil.")]
        public string MobileNO { get; set; }



        [Required(ErrorMessage = "{0} Gerekli"), Display(Name = "Role")]
        public byte RoleID { get; set; }


        public Role Role { get; set; } // navigasyon için gerekli

    }
}
