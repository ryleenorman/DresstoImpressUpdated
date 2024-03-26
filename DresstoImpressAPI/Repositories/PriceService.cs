//By Emily Mago
using DresstoImpressAPI.Data;
using DresstoImpressAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace DresstoImpressAPI.Repositories
{
    public class PriceService : IPriceService
    {
        private readonly DbContextClass _dbContextClass;
        public PriceService(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<List<Clothing>>GetPriceDetails(int clothingid)
        {
            var param = new SqlParameter("@ClothingID", clothingid);
            var PriceDetails = await _dbContextClass.Clothing.FromSqlRaw("exec GetPriceDetails @ClothingID", param).ToListAsync();  
            return PriceDetails;

        }
    }
}
