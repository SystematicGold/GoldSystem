using API.Entities;
using Microsoft.EntityFrameworkCore;
namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }
        public DbSet<DeffCaratOrGm_> DeffCaratOrGm { get; set; }
        public DbSet<DeffCountryOfOrigin_> DeffCountryOfOrigin { get; set; }
        public DbSet<DeffCustomer_> DeffCustomer { get; set; }
        public DbSet<DeffGoldBarCode_> DeffGoldBarCode { get; set; }
        public DbSet<DeffItemCondition_> DeffItemCondition { get; set; }
        public DbSet<DeffKarat_> DeffKarat { get; set; }
        public DbSet<DeffPayMethod_> DeffPayMethod { get; set; }
        public DbSet<DeffStoneClarity_> DeffStoneClarity { get; set; }
        public DbSet<DeffStoneColor_> DeffStoneColor { get; set; }
        public DbSet<DeffStoneCut_> DeffStoneCut { get; set; }
        public DbSet<DeffStoneName_> DeffStoneName { get; set; }
        public DbSet<DeffStoneType_> DeffStoneType { get; set; }
        public DbSet<DeffSupplier_> DeffSupplier { get; set; }
        public DbSet<DeffTaxExempt_> DeffTaxExempt { get; set; }
        public DbSet<GoldDeffItemName_> GoldDeffItemName { get; set; }
        public DbSet<GoldStock_> GoldStock { get; set; }
        public DbSet<GoldStone_> GoldStone { get; set; }
        public DbSet<User_> User { get; set; }
    }
}