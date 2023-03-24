using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayush_Test
{
    public class Add_Employee
    {
        
        Validations val = new Validations();
        public string Hobbies()
        {
            int no_of_hobbies;
            while (!int.TryParse(Console.ReadLine(), out no_of_hobbies))
            {
                Console.WriteLine();
                Console.WriteLine("Error: Please Provide valid no of Hobbies");
            }
            string UserHobby;
            string[] Hobby_Details = new string[no_of_hobbies];
            string hobby;
            
            for(int i = 0; i < no_of_hobbies;i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Please Provide Your Hobby{i+1}");
                hobby = val.CheckHobby(Console.ReadLine());
                Hobby_Details[i] = hobby;
            }
            UserHobby = string.Join(",", Hobby_Details);
            return UserHobby;
            
        }
       
        public void Add(List<Employee> list)
        {
            int id;
            if (list.Count==0)
            {
                id = 1; 
            }
            else
            {
                id = list.Max(x => x.Id)+1;
            }

            Console.WriteLine();
            Console.WriteLine("Please Provide Name");
            string name = val.CheckName(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Please Provide your department");
            string dept = val.CheckDept(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Please Provide DOB (YYYY/MM/DD)");
            string dob = val.CheckDob(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Please enter email");
            string email = val.CheckEmail(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Please Provide Your Salary");
            double salary = val.CheckSalary(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Please Provide no of hobbies do you have..");
            string hobbies = Hobbies();
            Employee emp = new Employee(id,name,dept,dob,email,salary,hobbies);
            list.Add(emp);
            Console.WriteLine();
            Console.WriteLine("Employee Details added Successfully");
            Console.WriteLine();
        }
    }
}
