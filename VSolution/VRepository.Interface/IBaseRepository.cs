using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using VSolution.VEntity;

namespace VSolution.VRepository.Interface
{
    public interface IBaseRepository<T>
        where T : BaseEntity,new()
    {
        IQueryable<T> GetEntityList();
        bool CreateEntity(T entity);
        int CreateEntities(ICollection<T> entities);
        bool UpdateEntity(T entity);
        int UpdateEntities(ICollection<T> entities);
        bool DeleteEntity(T entity);
        int DeleteEntities(ICollection<T> entities);
    }
}
