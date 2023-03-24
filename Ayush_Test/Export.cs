using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayush_Test
{
    public class Export
    {
        public void ExportCsv(List<Employee>list)
        {
          
            if(list.Count > 0)
            {
                string path = @"D:\export.csv";
                using(FileStream file = new FileStream(path,FileMode.Create,FileAccess.Write))
                {
                    using(StreamWriter writer = new StreamWriter(file))
                        {
                            writer.WriteLine($"ID,Name,Department,DOB,Email,Salary,Hobbies");
                            foreach(Employee emp in list)
                            {
                                writer.WriteLine($"{ emp.Id},{ emp.Name},{ emp.Department},{ emp.Dob},{ emp.Email},{ emp.Salary},{ emp.Hobbies}");
                          
                            }
                        }
                    Console.WriteLine();
                    Console.WriteLine("Export Success");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Please Add Employee details to Employee List");
                Console.WriteLine();
            }
        }
    }
}
