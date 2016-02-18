using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using VSolution.Common;
using VSolution.VBusiness.Interface;
using VSolution.VEntity;
using VSolution.VRepository.Interface;

namespace VSolution.VBusiness
{
    public class UserBusiness : BaseBusiness, IUserBusiness
    {
        public bool Register(User user)
        {
            var userRepository = GlobalObject.HttpConfiguration.DependencyResolver.GetService(typeof(IUserRepository)) as IUserRepository;
            return userRepository != null && userRepository.CreateEntity(user);
        }
    }
}
