using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSolution.VEntity;
using VSolution.VRepository.Interface;

namespace VSolution.VRepository.SqlServer
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        //public new bool CreateEntity(User entity)
        //{
        //    Context.User.Add(entity);
        //    return Context.SaveChanges() == 1;
        //}
    }
}
