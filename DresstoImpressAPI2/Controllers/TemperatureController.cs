// Emily Surface 
using DresstoImpressAPI.Entities;
using DresstoImpressAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DresstoImpressAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemperatureController : ControllerBase
    {
        private readonly ITemperatureService _temperature;

        public TemperatureController(ITemperatureService temperature)
        {
            _temperature = temperature;
        }

        [HttpGet("{WeatherId}")]
        public async Task<ActionResult<List<Weather>>> GetTemperature(int WeatherId)
        {
            var temperatures = await _temperature.GetTemperature(WeatherId);
            if (temperatures == null)
            {
                return NotFound();
            }
            return temperatures;
        }
    }
}
