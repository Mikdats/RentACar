using System;
using System.ComponentModel.DataAnnotations;

namespace RentACar.Models
{
    public class Car
    {
        [Key]     
        public int CarID { get; set; }

        [Required(ErrorMessage = "{0} boş bırakılamaz!"), Display(Name = "Marka")]
        public byte BrandID { get; set; }

        [Required(ErrorMessage = "{0} boş bırakılamaz!"), Display(Name = "Renk")]
        public byte CarColorID { get; set; }

        [Required(ErrorMessage = "{0} boş bırakılamaz!"), Display(Name = "Araba Modeli"), StringLength(50, MinimumLength = 3, ErrorMessage = "{0} {2}-{1} karakter arasında olmalı!")]
        public string CarModel { get; set; }

        [Required(ErrorMessage = "{0} boş bırakılamaz!"), Display(Name = "Yakıt Tipi")]
        public byte FuelTypeID { get; set; }

        [Required(ErrorMessage = "{0} boş bırakılamaz!"), Display(Name = "Vites Tipi")]
        public byte GearTypeID { get; set; }

        [Required(ErrorMessage = "{0} boş bırakılamaz!"), Display(Name = "Koltuk Sayısı")]
        public byte SeatNumber { get; set; }

        [Required(ErrorMessage = "{0} boş bırakılamaz!"), Display(Name = "Kasa Tipi")]
        public byte BodyTypeID { get; set; }

        [Required(ErrorMessage = "{0} boş bırakılamaz!"), Display(Name = "Bagaj Hacmi")]
        public short LuggageVolume { get; set; }

        [Required(ErrorMessage = "{0} boş bırakılamaz!"), Display(Name = "Model Yılı")]
        public short ModelYear { get; set; }
        





        public Brand Brand { get; set; }
        public CarColor CarColor { get; set; }
        public FuelType FuelType { get; set; }
        public GearType GearType { get; set; }
        public BodyType BodyType { get; set; }


    }
}
