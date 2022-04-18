using System.ComponentModel.DataAnnotations;

namespace RentACar.Models
{
    public class GearType
    {
        [Key]
        public byte GearTypeID { get; set; }
        [Required(ErrorMessage = "{0} boş bırakılamaz!"),
        Display(Name = "Vites Türü"),
        StringLength(20, MinimumLength = 3, ErrorMessage = "{0} {2}-{1} karakter arasında olmalı!")]
        public string GearTypeName { get; set; }
    }
}