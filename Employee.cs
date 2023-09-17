using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Employee
    {
        private string lastName;
        private string firstName;
        private string position;
        private int experience;

        public string LastName { get; internal set; }
        public string FirstName { get; internal set; }
        public string Position { get; internal set; }

        public Employee(string lastName, string firstName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
        }

        public void SetPosition(string position)
        {
            this.position = position;
        }

        public void SetExperience(int experience)
        {
            this.experience = experience;
        }

        public double CalculateSalary()
        {
            return 0.0;
        }

        public double CalculateTax()
        {
            return 0.0;
        }
    }
}
