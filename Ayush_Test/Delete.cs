using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayush_Test
{
    public class DeleteEmp
    {
        Validations val = new Validations();
        
        public void Delete(List<Employee> list)
        {
            Console.WriteLine("Enter Id Please");
            int id = val.CheckId();
            Employee emp = list.Find(em => em.Id == id);
            if(emp == null)
            {
                Console.WriteLine();
                Console.WriteLine("Please Provide valid Id present in Employee List");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Are You Sure want to delete the details of the id = {id}(Y/y)");
                string input = Console.ReadLine();
                if(input=="Y"||input=="y")
                    {
                    Console.WriteLine();
                    list.Remove(emp);
                    Console.WriteLine("Delete Success");
                    Console.WriteLine();
                }
            }
        }
        
    }
}
