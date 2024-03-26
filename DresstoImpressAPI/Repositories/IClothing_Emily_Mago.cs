using DresstoImpressAPI.Entities;

namespace DresstoImpressAPI.Repositories
{
    public interface IClothing_Emily_Mago
    {
        public Task<List<Outfit>> GetOutfitDetails(int outfitid);  
    }
}
