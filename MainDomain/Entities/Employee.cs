using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainDomain.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        //persons name
        public string Name { get; set; }

        //teams he engaged in
        public List<ProjectTeam> TeamsEngaged;


        //Maximum number of project employee can be engaged in
        private int MaxCapacity = 3;
        //Current number of projects employee is engaged in
        private int _capacity=0;
        public int Capacity
        {
            get
            {
                return _capacity;
            }
            set
            {
                if (value <= MaxCapacity)
                {
                    _capacity = value;
                }
                else
                {
                    throw new ArgumentException("Employee can't be assigned to more than 3 projects", "original");
                }
            }
        }
        //Availiability status of employee
        bool Availiable
        {
            get
            {
                if (_capacity < MaxCapacity)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
