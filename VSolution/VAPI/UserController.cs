using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using VSolution.Common;
using VSolution.VBusiness.Interface;
using VSolution.VEntity;

namespace VSolution.VAPI
{
    /// <summary>
    /// 
    /// </summary>
    public class UserController : BaseController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost, Route("user")]
        public bool Register(User user)
        {
            var userBusiness = GlobalObject.HttpConfiguration.DependencyResolver.GetService(typeof(IUserBusiness)) as IUserBusiness;
            return userBusiness != null && userBusiness.Register(user);
        }
    }
}