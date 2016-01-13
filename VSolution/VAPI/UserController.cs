using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using VSolution.VEntity;

namespace VSolution.VAPI
{
    public class UserController : BaseController
    {
        [HttpPost, Route("user")]
        public void Register(User user)
        {
            
        }
    }
}
