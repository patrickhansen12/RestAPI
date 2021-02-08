
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
      
        }
        // Saving to database
        public DbSet<Product> Products
        {
            get; set;
        }
    }
}
