using System.ComponentModel.DataAnnotations;

namespace RentACar.Models
{
    public class CarColor
    {
        [Key]
        public byte CarColorID { get; set; }
        [Required(ErrorMessage = "{0} boş bırakılamaz!"),
         Display(Name = "Renk"),
         StringLength(20, MinimumLength = 3, ErrorMessage = "{0} {2}-{1} karakter arasında olmalı!")]
        public string CarColorName { get; set; }
    }
}