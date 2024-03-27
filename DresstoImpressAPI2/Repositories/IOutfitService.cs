using DresstoImpressAPI2.Entities;

namespace DresstoImpressAPI2.Repositories
{
    public interface IOutfitService
    {
        public Task<List<Outfit>> GetOutfitDetails(int OutfitID);
    }
}
