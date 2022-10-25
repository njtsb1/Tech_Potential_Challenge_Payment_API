using Microsoft.EntityFrameworkCore;
using Tech_Potential_Challenge_Payment_API.Models;

namespace Tech_Potential_Challenge_Payment_API.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
                        
        }

        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleItems> SalesItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Seller>(s => {
                s.HasKey(s => s.Id);
            });

            modelBuilder.Entity<Product>(p => {
                p.HasKey(p => p.Id);
            });

            modelBuilder.Entity<Sale>(s => {
                s.HasKey(s => s.Id);

                s.HasOne<Seller>(s => s.Seller)
                .WithOne()
                .HasForeignKey<Seller>(se => se.Id);

                s.HasMany(s => s.Items)
                 .WithOne()
                 .HasForeignKey(si => si.SaleId);
            });       

            modelBuilder.Entity<SaleItems>(si => {
                si.HasKey(si => si.Id);

                si.HasOne<Sale>(si => si.Sale)
                .WithOne()
                .HasForeignKey<Sale>(s => s.Id);

                si.HasOne<Product>(si => si.Produtct)
                .WithOne()
                .HasForeignKey<Product>(p => p.Id);                                
            });
        }
    }
}