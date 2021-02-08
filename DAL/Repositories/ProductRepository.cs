using DAL.Entities;
using DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        TContext context;
        // Makes the context available in the class
        public ProductRepository(TContext context)
        {
            this.context = context;
        }

        // Add a product to the context
        public Product Create(Product product)
        {
            context.Products.Add(product);
            return product;
        }

        // Remove a singleroom from the context by it's id if it exists
        public Product Delete(int Id)
        {
            var product = Get(Id);
            if (product != null)
            {
                context.Products.Remove(product);
            }

            return product;
        }

        // Get a singleroom from the context by it's id
        public Product Get(int Id) => context.Products.FirstOrDefault(s => s.Id == Id);

        // Get all singlerooms from the context as a list
        public IEnumerable<Product> GetAll() => context.Products.ToList();


    }
}
