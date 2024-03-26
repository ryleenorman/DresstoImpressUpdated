using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DresstoImpressAPI.Entities
{
    public class Outfit
    {
        public int OutfitID { get; set; }
        public int WeatherID { get; set; }
        public int ClothingID { get; set; }
        public string OutfitOccasion { get; set; }
    }
}
