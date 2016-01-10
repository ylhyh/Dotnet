using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSolution.VEntity;
using VSolution.VRepository.Interface;

namespace VSolution.VRepository.SqlServer
{
    public class BaseRepository<T> where T : BaseEntity
    {
        public DbContext Context
        {
            get
            {
                return new DbContext("VDatabaseConnect");
            }
        }

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
