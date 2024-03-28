// Emily Surface 
using DresstoImpressAPI.Entities;
using System.Threading.Tasks;

namespace DresstoImpressAPI.Repositories
{


    public interface ITemperatureService
    {
        Task<List<Weather>> GetTemperature(int WeatherID);
    }
}