//Rylee Norman

using DresstoImpressAPI.Entities;

namespace DresstoImpressAPI.Repositories
{
    public interface IClothingSeasonService
    {
        public Task<List<ClothingBySeason>> GetClothingbySeason(int ClohtingID);
    }
}
