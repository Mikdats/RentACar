using System.ComponentModel.DataAnnotations;

namespace RentACar.Models
{
    public class Brand
    {
        [Key]
        public byte BrandID { get; set; }


        [Required(ErrorMessage ="{0} boş bırakılamaz!"),
         Display(Name ="Marka"),
         StringLength(20,MinimumLength =3,ErrorMessage ="{0} {2}-{1} karakter arasında olmalı!")]
        public string BrandName { get; set; }


    }
}