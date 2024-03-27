using System.ComponentModel.DataAnnotations;

namespace DresstoImpressAPI2.Entities
{
    public class ClothingBySeason
    {
        [Key]
        public int ClothingID { get; set; }
        public string? ClothingSeason { get; set; }
    }
}
