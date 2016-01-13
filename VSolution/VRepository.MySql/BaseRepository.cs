using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSolution.VEntity;

namespace VSolution.VRepository.MySql
{
    public class BaseRepository<T> where T: BaseEntity
    {
        public IQueryable<T> GetEntityList()
        {
            throw new NotImplementedException();
        }

        public bool CreateEntity(T entity)
        {
            throw new NotImplementedException();
        }

        public int CreateEntities(ICollection<T> entities)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEntity(T entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateEntities(ICollection<T> entities)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEntity(T entity)
        {
            throw new NotImplementedException();
        }

        public int DeleteEntities(ICollection<T> entities)
        {
            throw new NotImplementedException();
        }
    }
}
