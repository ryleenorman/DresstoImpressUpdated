using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DresstoImpressAPI.Entities
{
    public class Weather
    {
        [Key]
        public int WeatherID { get; set; }

        public string WeatherType { get; set; }

        public string Temperature { get; set; }

        public string Precipitation { get; set; }
    }

}

