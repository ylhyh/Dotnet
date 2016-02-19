using System.Data.Entity;
using EF6Demo.CodeFirst.Entities;

namespace EF6Demo.CodeFirst
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext() : base("VDatabaseConnect")
        {

        }

        public DbSet<User> Users
        {
            get;
            set;
        }

        public DbSet<Group> Groups
        {
            get;
            set;
        }
    }
}
