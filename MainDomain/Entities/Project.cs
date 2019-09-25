using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainDomain.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public int ClientId { get; set; }

        //Clients info
        [Required]
        public virtual Client Client { get; set; }

        //projects name
        string Name { get; set; }
        //projects Description
        string Desctiption { get; set; }
        //projects difficulty
        string Difficulty { get; set; }
        //Duration of the project
        int Duration { get; set; }
    }
}
