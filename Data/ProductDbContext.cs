using Microsoft.EntityFrameworkCore;
using ProductsInventory.Model;

namespace ProductsInventory.Data
{
    public class ProductDbContext :DbContext
    {  public ProductDbContext(DbContextOptions<ProductDbContext> options): base(options) { }
        public DbSet <Product> Products { get; set; }
    }
}
