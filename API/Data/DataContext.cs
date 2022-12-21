using API.Entities;
using Microsoft.EntityFrameworkCore;
namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }
        public DbSet<Users> Users { get; set; }
        public DbSet<DeffStoneName> DeffStoneName { get; set; }
        public DbSet<DeffCountryOfOrigin> DeffCountryOfOrigin { get; set; }
        public DbSet<DeffSupplier> DeffSupplier { get; set; }
        public DbSet<GoldStone> GoldStone { get; set; }
        public DbSet<DeffKarat> DeffKarat { get; set; }
        public DbSet<DeffStoneColor> DeffStoneColor { get; set; }
        public DbSet<GoldDeffItemName> GoldDeffItemName { get; set; }
        public DbSet<GoldStock> GoldStock { get; set; }
        public DbSet<DeffCustomer> DeffCustomer { get; set; }
    }
}