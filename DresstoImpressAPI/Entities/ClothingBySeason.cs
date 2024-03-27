using System.ComponentModel.DataAnnotations;

namespace DresstoImpressAPI.Entities
{
    public class ClothingBySeason
    {
        [Key]
        public int ClothingID { get; set; }
        public string? ClothingSeason { get; set; }

    }
   
}
