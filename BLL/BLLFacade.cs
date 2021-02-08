using DAL;
using System;

namespace BLL
{
    public class BLLFacade : IBLLFacade
    {
        DALFacade facade;
        public BLLFacade(IConfiguration conf)
        {
            facade = new DALFacade(new DbOptions()
            {
                ConnectionString = conf.GetConnectionString("SecretConnectionString"),
                Environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")
            });
        }
        public IService<ProductBO> ProductService => new ProductService(facade);

  
    }
}