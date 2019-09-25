using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MainDomain.Entities;

namespace MainDomain.Repositories
{
    public class SystemContext : DbContext
    {
        public SystemContext()
           : base("DbConnection")
        { }
        static SystemContext()
        {
            Database.SetInitializer<SystemContext>(new DatabaseInitializer());
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectTeam> ProjectTeams { get; set; }
    }
}
