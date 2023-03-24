using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayush_Test
{
    public static class ListAllEmployee
    {
        public static void Details(List<Employee> list)
        {
            if (list.Count > 0)
            {
                Console.WriteLine("Id\tName\tDepartment\tDob\tEmail\tSalary\tHobbies");
                foreach (Employee item in list)
                {
                    Console.WriteLine("{0}\t {1}\t {2}\t{3}\t{4}\t{5}\t{6}", item.Id, item.Name, item.Department,item.Dob,item.Email,item.Salary,item.Hobbies);
                }
            }
            else 
            {
                Console.WriteLine();
                Console.WriteLine("Employee List is Empty");
                Console.WriteLine();
            }
        }
    }
}
