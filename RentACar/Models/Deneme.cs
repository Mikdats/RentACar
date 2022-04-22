using System.ComponentModel.DataAnnotations;

namespace RentACar.Models
{
    public class Deneme
    {
        [Key]
        public int DenemeId { get; set; }
        public string DenemeName { get; set; }

    }
}
