using Microsoft.EntityFrameworkCore;
using TakeCommand.Data.Models;

namespace TakeCommand.Data
{
    public class ShopContext : DbContext
    {

        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
        }

        public DbSet<ProductDto> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Shop");

            modelBuilder.Entity<ProductDto>().ToTable("Product").HasKey(s => s.Id);

        }

        // public DbSet<StudentDto> Students { get; set; }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<ProductDto>().ToTable("Product").HasKey(s => s.Id);
        //     //  modelBuilder.Entity<GradeDto>().ToTable("Grade").HasKey(s => s.GradeId);
        // }

    }
}
