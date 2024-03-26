//By Emily Mago
using DresstoImpressAPI.Entities;

namespace DresstoImpressAPI.Repositories
{
    public interface IOutfitService
    {
        public Task<List<Outfit>> GetOutfitDetails(int outfitid);  
    }
}
