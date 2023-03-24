using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayush_Test
{
    public class Edit
    {
        Validations val = new Validations();
        public void EditEmployee(List<Employee> employees)
        {
            Console.WriteLine("Enter Id Please");
            int id = val.CheckId();
           Employee emp = employees.Find(x => x.Id == id);
            if (emp == null)
            {
                Console.WriteLine("Please provide a valid id which is in employee list");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine( "1. Edit Department" + "\n" +
                                   "2. Edit Dob" + "\n" +
                                   "3. Edit Salary " + "\n" +
                                   "4. Edit Hobbies " + "\n" +
                                   "5. Edit Department,Dob,Salary,Hobbies");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        {
                            Console.WriteLine("Edit Department");
                            string Department = val.CheckDept(Console.ReadLine());
                            employees.Find(em => em.Id == id).Department = Department;
                            Console.WriteLine();
                            Console.WriteLine("Edit Department Success");
                            Console.WriteLine();
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Edit DOB");
                            string dob = val.CheckDob(Console.ReadLine());
                            employees.Find(em => em.Id == id).Dob = dob;
                            Console.WriteLine("Edit DOB Success");
                            Console.WriteLine();
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Edit Salary");
                            double salary = val.CheckSalary(Console.ReadLine());
                            employees.Find(em => em.Id == id).Salary = salary;
                            Console.WriteLine();
                            Console.WriteLine("Edit Salary Success");
                            Console.WriteLine();
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("Edit Hobbies");
                            Add_Employee add = new Add_Employee();
                            Console.WriteLine("Please Provide no of hobbies do you have..");
                            string hobbies = add.Hobbies();
                            employees.Find(em => em.Id == id).Hobbies = hobbies;
                            Console.WriteLine();
                            Console.WriteLine("Edit Hobbies Success");
                            Console.WriteLine();
                            break;
                        }
                    case "5":
                        {
                            Console.WriteLine("Edit Department,DOB,Salary,Hobbies");
                            Console.WriteLine("Edit Department");
                            string Department = val.CheckDept(Console.ReadLine());
                            employees.Find(em => em.Id == id).Department = Department;

                            Console.WriteLine("Edit DOB");
                            string dob = val.CheckDob(Console.ReadLine());
                            employees.Find(em => em.Id == id).Dob = dob;

                            Console.WriteLine("Edit Salary");
                            double salary = val.CheckSalary(Console.ReadLine());
                            employees.Find(em => em.Id == id).Salary = salary;

                            Console.WriteLine("Edit Hobbies");
                            Add_Employee add = new Add_Employee();
                            Console.WriteLine("Please Provide no of hobbies do you have..");
                            string hobbies = add.Hobbies();
                            employees.Find(em => em.Id == id).Hobbies = hobbies;
                            Console.WriteLine();
                            Console.WriteLine("Edit Department, DOB, Salary, Hobbies Success");
                            Console.WriteLine();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please Provide Input in the range of 1 to 5");
                            Console.WriteLine();
                            break;
                        }

                }
            }

        }
    }
}
