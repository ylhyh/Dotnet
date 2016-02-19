using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6Demo.CodeFirst.Entities
{
    public class Group
    {
        public int GroupId
        {
            get; set;
        }

        public string GroupName
        {
            get; set;
        }

        public virtual List<User> Users
        {
            get; set;
        }
    }
}
