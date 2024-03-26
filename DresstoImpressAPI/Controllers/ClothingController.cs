using DresstoImpressAPI.Entities;
using DresstoImpressAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DresstoImpressAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClothingController : Controller
    {
        private readonly IClothing_Emily_Mago emily_mago_clothing;
            public ClothingController(IClothing_Emily_Mago Emily_Mago_Clothing) 
        {
            this.emily_mago_clothing = Emily_Mago_Clothing;
        }
        [HttpGet("{outfitid}")]
       public async  Task<List<Outfit>> GetOutfitDetails(int outfitid)
        {
            var outfitDetails = await emily_mago_clothing.GetOutfitDetails(outfitid);
           /* if (outfitid == null)
            {
                return NotFound()
            }*/
            return outfitDetails;
        }
    }
}
