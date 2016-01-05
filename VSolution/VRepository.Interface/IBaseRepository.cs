using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace VSolution.VRepository.Interface
{
    public interface IBaseRepository<T>
        where T : class
    {
        IQueryable<T> GetEntityList();
        bool CreateEntity<T>(T entity);
        int CreateEntities<T>(ICollection<T> entities);
        bool UpdateEntity<T>(T entity);
        int UpdateEntities<T>(ICollection<T> entities);
        bool DeleteEntity<T>(T entity);
        int DeleteEntities<T>(ICollection<T> entities);
    }
}
