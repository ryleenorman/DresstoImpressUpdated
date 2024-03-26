//By Emily Mago
using DresstoImpressAPI.Entities;

namespace DresstoImpressAPI.Repositories
{
    public interface IPriceService
    {
        public Task<List<Clothing>> GetPriceDetails(int clothingid);

    }
}
