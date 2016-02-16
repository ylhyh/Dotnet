using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSolution.VEntity;

namespace VSolution.VRepository.SqlServer
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base("VDatabaseConnect")
        {

        }
        
        public DbSet<User> User
        {
            get;
            set;
        }
    }
}
