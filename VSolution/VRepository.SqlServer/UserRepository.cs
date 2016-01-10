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
    }
}
