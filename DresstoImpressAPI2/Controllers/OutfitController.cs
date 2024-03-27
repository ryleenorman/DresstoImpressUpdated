using DresstoImpressAPI2.Entities;
using DresstoImpressAPI2.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DresstoImpressAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OutfitController : Controller
    {
        private readonly IOutfitService outfitService;

        public OutfitController(IOutfitService outfitService)
        {
            this.outfitService = outfitService;
        }
        [HttpGet("{OutfitID}")]
        public async Task<List<Outfit>> GetOutfitDetails(int OutfitID)
        {
            var outfitDetails = await outfitService.GetOutfitDetails(OutfitID);
            if (outfitDetails == null)
            {
                //return NotFound();
            }
            return outfitDetails;
        }
    }
}
