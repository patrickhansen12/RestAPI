using DAL.Entities;
using DAL.Repositories;
using System;


namespace DAL.UOW
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Product> ProductRepository
        {
            get;
        }
        int Complete();
    }
}
