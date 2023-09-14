
using Microsoft.EntityFrameworkCore;
using Product.Domain;

namespace Product.Data.Context
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Producto> Products { get; set; }
    }
}