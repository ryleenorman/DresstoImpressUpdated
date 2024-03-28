using System.ComponentModel.DataAnnotations;

namespace DresstoImpressAPI2.Entities
{
    public class WeatherByType
    {
        [Key]
        public int WeatherID { get; set; }
        public string? WeatherType { get; set; }
    }
}
