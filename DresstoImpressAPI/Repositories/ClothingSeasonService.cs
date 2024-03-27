using DresstoImpressAPI.Data;
using DresstoImpressAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace DresstoImpressAPI.Repositories
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClothingSeasonService : IClothingSeasonService
    {
        private readonly DbContextClass _dbContextClass;
        public ClothingSeasonService(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<List<ClothingBySeason>> GetClothingbySeason(int ClothingID)
        {
            var param = new SqlParameter("@ClothingID", ClothingID);
            var getClothingbySeason = await Task.Run(() => _dbContextClass.Clothing.FromSqlRaw("exec GetClothingbySeason @ClothingID", param).ToListAsync());
            return getClothingbySeason;
        }

    }
}
