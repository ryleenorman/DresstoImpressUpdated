using DresstoImpressAPI.Data;
using DresstoImpressAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace DresstoImpressAPI.Repositories
{
    public class Emily_Mago_Clothing : IClothing_Emily_Mago
    {
        private readonly DbContextClass _dbContextClass;
        public Emily_Mago_Clothing(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<List<Emily_Mago_Clothing>> GetOutfitDetails(int outfitid, List<Emily_Mago_Clothing> outfitDetails)
        {
            var param = new SqlParameter("@OutfitID", outfitid);
            var OutfitDetails = await Task.Run(() => _dbContextClass.Outfit.FromSqlRaw("exec SQL_Rylee_Norman_Get_Outfit_Details @OutfitID", param).ToListAsync());
            return outfitDetails;
            

        }

      
    }
}
