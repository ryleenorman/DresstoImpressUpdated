using DresstoImpressAPI2.Entities;
using DresstoImpressAPI2.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DresstoImpressAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClothingSeasonController : Controller
    {
        private readonly IClothingSeasonService clothingSeasonService;

        public ClothingSeasonController(IClothingSeasonService clothingSeasonService)
        {
            this.clothingSeasonService = clothingSeasonService;
        }
        [HttpGet("{ClothingID}")]
        public async Task<List<ClothingBySeason>> GetClothingbySeason(int ClothingID)
        {
            var clothingbySeason = await clothingSeasonService.GetClothingbySeason(ClothingID);
            if (clothingbySeason == null)
            {
                //return NotFound();
            }
            return clothingbySeason;
        }

    }
}
