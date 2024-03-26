//By Emily Mago
using DresstoImpressAPI.Entities;
using DresstoImpressAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DresstoImpressAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriceController : Controller
    {
        private readonly IPriceService price_em;
        public PriceController(IPriceService Price_EM)
        {
            this.price_em = Price_EM;
        }
        [HttpGet("{clothingid}")]
        public async Task<List<Clothing>> GetPriceDetails(int clothingid)
        {
            var PriceDetails = await price_em.GetPriceDetails(clothingid);

            return PriceDetails;
        }
    }
}












