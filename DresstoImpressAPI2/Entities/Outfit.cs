using System.ComponentModel.DataAnnotations;

namespace DresstoImpressAPI2.Entities
{
    public class Outfit
    {
        [Key]
        public int OutfitID { get; set; }

        [Required]
        public int WeatherID { get; set; }

        [Required]
        public int ClothingID { get; set; }

        public string OutfitOccasion { get; set; }
    }
}
