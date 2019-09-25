using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainDomain.Entities
{
    public class ProjectTeam
    {
        public int Id { get; set; }

        public int ProjectId { get; set; }
        //current project team is working on
        [Required]
        Project Project { get; set; }

        //List of employees working on the project
        List<Employee> Members;
        public int MembersId { get; set; }
    }
}
