using Microsoft.EntityFrameworkCore;
using Module12inclass.Models;
using System.Collections.Generic;

namespace Module12inclass.ProductDao
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }

} 