using System.ComponentModel.DataAnnotations;

namespace RentACar.Models
{
    public class BodyType
    {
        [Key]
        public byte BodyTypeID { get; set; }
        [Required(ErrorMessage = "{0} boş bırakılamaz!"),
        Display(Name = "Kasa Türü"),
        StringLength(20, MinimumLength = 3, ErrorMessage = "{0} {2}-{1} karakter arasında olmalı!")]
        public string BodyTypeName { get; set; }
    }
}