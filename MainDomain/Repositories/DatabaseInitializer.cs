using MainDomain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainDomain.Repositories
{
    public class DatabaseInitializer : DropCreateDatabaseAlways<SystemContext>
    {
        protected override void Seed(SystemContext db)
        {
            Employee Tomas = new Employee() { Name = "Tom", Capacity = 0 };
            db.Employees.Add(Tomas);
            db.SaveChanges();
            

            
            
        }
    }
}
