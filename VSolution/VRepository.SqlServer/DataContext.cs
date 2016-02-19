using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSolution.VEntity;

namespace VSolution.VRepository.SqlServer
{
    public class DataContext : DbContext
    {
        static DataContext()
        {
            //Database.SetInitializer<DataContext>(new CreateDatabaseIfNotExists<DataContext>());
        }
        
        public DataContext()
            : base("VDatabaseConnect")
        {
            //禁用延迟加载
            //this.Configuration.LazyLoadingEnabled = false;
            //this.Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users
        {
            get;
            set;
        }
    }
}
