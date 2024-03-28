using DresstoImpressAPI2.Entities;

namespace DresstoImpressAPI2.Repositories
{
    public interface IWeatherTypeService
    {
        public Task<List<WeatherByType>> GetWeatherByType(int WeatherID);
    }
}
