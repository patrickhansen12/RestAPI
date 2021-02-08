
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context
{
     public class TContext: DbContext
    {
      
        public TContext(DbContextOptions<TContext> options) : base(options)
        {
        }

       
        // Saving to database
        public DbSet<Product> Products
        {
            get; set;
        }
    }
}
