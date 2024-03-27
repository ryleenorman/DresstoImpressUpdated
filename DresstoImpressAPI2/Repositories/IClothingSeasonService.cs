using DresstoImpressAPI2.Entities;

namespace DresstoImpressAPI2.Repositories
{
    public interface IClothingSeasonService
    {
        public Task<List<ClothingBySeason>> GetClothingbySeason(int ClohtingID);
    }
}
