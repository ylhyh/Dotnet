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
        public DataContext Context
        {
            get
            {
                return new DataContext();
            }
        }

        public IQueryable<T> GetEntityList()
        {
            return Context.Set<T>().AsQueryable();
        }

        public virtual bool CreateEntity(T entity)
        {
            Context.Set<T>().Add(entity);
            return Context.SaveChanges() == 1;

            using (var db = new DataContext())
            {

            }
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
