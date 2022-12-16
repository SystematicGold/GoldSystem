using API.Entities;
using Microsoft.EntityFrameworkCore;
namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }
        public DbSet<Users> Users { get; set; }
        public DbSet<Categories> Category { get; set; }
        public DbSet<StoneCategoris> StoneCategory { get; set; }
        public DbSet<StoneItemCategories> StoneItemCategory { get; set; }
        public DbSet<KaratItem> KartItems { get; set; }
        public DbSet<ItemName> ItemNames { get; set; }
        public DbSet<MadeCountry> MadeCountrys { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}