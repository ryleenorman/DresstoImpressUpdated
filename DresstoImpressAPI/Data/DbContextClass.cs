using DresstoImpressAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace DresstoImpressAPI.Data
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options)
        { }
        public DbSet<Clothing> Clothing { get; set; }   

        public DbSet<Outfit> Outfit { get; set; }   

        public DbSet<Users> Users { get; set; } 

        public DbSet<Weather> Weather { get; set; }
    }
}
