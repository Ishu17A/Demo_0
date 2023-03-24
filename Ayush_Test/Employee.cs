using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayush_Test
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Dob { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }
        public string Hobbies { get; set; }
        public Employee(int id, string name, string department, string dob, string email,double salary, string hobbies)
        {
            this.Id = id;
            this.Name = name;
            this.Department = department;
            this.Dob = dob;
            this.Email = email;
            this.Salary = salary;
            this.Hobbies = hobbies;
        }
    }
    
}
