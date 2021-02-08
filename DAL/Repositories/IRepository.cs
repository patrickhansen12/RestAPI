using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IRepository<IEntity>
    {
    //Create new entity
    IEntity Create(IEntity ent);
    //Get all entities of this type
    IEnumerable<IEntity> GetAll();
    //Get one entity by it's id
    IEntity Get(int Id);
    //Delete an exsisting entity by it's id
    IEntity Delete(int Id);
}
}
