using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainDomain.Entities
{
    public class Client
    {
        public int Id { get; set; }

        //Clients name
        string Name { get; set; }


        //lients project
        Project DesiredProject { get; set; }
    }
}
