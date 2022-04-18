using System.ComponentModel.DataAnnotations;

namespace RentACar.Models
{
    public class FuelType
    {
        [Key]
        public byte FuelTypeID { get; set; }
        [Required(ErrorMessage = "{0} boş bırakılamaz!"),
        Display(Name = "Yakıt"),
        StringLength(20, MinimumLength = 3, ErrorMessage = "{0} {2}-{1} karakter arasında olmalı!")]
        public string FuelTypeName { get; set; }
    }
}