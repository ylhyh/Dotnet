using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSolution.VRepository.Interface;

namespace VSolution.VRepository.SqlServer
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class,new()
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

        public bool CreateEntity<T>(T entity)
        {
            throw new NotImplementedException();
        }

        public int CreateEntities<T>(ICollection<T> entities)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEntity<T>(T entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateEntities<T>(ICollection<T> entities)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEntity<T>(T entity)
        {
            throw new NotImplementedException();
        }

        public int DeleteEntities<T>(ICollection<T> entities)
        {
            throw new NotImplementedException();
        }
    }
}
