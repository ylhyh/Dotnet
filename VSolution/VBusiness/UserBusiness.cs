using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSolution.VBusiness.Interface;
using VSolution.VEntity;
using VSolution.VRepository.Interface;

namespace VSolution.VBusiness
{
    public class UserBusiness : BaseBusiness, IUserBusiness
    {
        public bool Register(User user)
        {
            var userRepository = Resolver.GetService(typeof(IUserRepository)) as IUserRepository;
            return userRepository != null && userRepository.CreateEntity(user);
        }
    }
}
