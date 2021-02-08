using DAL.UOW;
using Microsoft.Extensions.Options;
using System;

namespace DAL
{
    public class DALFacade
    {
        DbOptions opt;
        public DALFacade(DbOptions opt)
        {
            this.opt = opt;
        }

        public IUnitOfWork UnitOfWork => new UnitOfWork(opt);
    }
}
