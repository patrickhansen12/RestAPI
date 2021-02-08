using DAL.Context;
using DAL.Entities;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        public IRepository<Product> ProductRepository
        {
            get; internal set;
        }
        TContext context;
        // Savechanges represents the number of of objects  written to the underlying database
        public UnitOfWork(DbOptions opt)
        {
            DbContextOptions<TContext> options;

            // Connects to our actual database


            options = new DbContextOptionsBuilder<TContext>()
            .UsingSqlServer(opt.ConnectionString)
                .Options;


            // Ensures that the database exsists
            context = new TContext(options);
            context.Database.EnsureCreated();
        }
            public int Complete() => context.SaveChanges();

        // Dispose context when it is done
        public void Dispose() => context.Dispose();
    }
}
