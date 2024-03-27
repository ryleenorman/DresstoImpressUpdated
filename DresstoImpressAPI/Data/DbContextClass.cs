using DresstoImpressAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace DresstoImpressAPI.Data
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options)
        {

        }
        public DbSet<Outfit> Outfit { get; set; }   
    }
}
