using DresstoImpressAPI2.Data;
using DresstoImpressAPI2.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace DresstoImpressAPI2.Repositories
{
    public class WeatherTypeService : IWeatherTypeService
    {
        private readonly DbContextClass _dbContextClass;
        public WeatherTypeService(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<List<WeatherByType>> GetWeatherByType(int WeatherID)
        {
            var param = new SqlParameter("@WeatherID", WeatherID);
            var getWeatherByType = await Task.Run(() => _dbContextClass.WeatherByType.FromSqlRaw("exec GetWeatherByType @WeatherID", param).ToListAsync());
            return getWeatherByType;
        }
    }
}
