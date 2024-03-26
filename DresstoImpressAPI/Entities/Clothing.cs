using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DresstoImpressAPI.Entities
{
    public class Clothing
    {
            public int ClothingID { get; set; }
            public string ClothingType { get; set; }
            public string ClothingSize { get; set; }
            public string ClothingColor { get; set; }
            public string ClothingSeason { get; set; }
            public decimal Price { get; set; }
        }

    }
}
