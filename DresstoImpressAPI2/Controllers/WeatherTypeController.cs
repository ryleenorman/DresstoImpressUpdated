using DresstoImpressAPI2.Entities;
using DresstoImpressAPI2.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DresstoImpressAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherTypeController : Controller
    {
        private readonly IWeatherTypeService weatherTypeService;

        public WeatherTypeController(IWeatherTypeService weatherTypeService)
        {
            this.weatherTypeService = weatherTypeService;
        }
        [HttpGet("{WeatherID}")]
        public async Task<List<WeatherByType>> GetWeatherByType(int WeatherID)
        {
            var getWeatherByType = await weatherTypeService.GetWeatherByType(WeatherID);
            if (getWeatherByType == null)
            {
                //return NotFound();
            }
            return getWeatherByType;
        }
    }
}
