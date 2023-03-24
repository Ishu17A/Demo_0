using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayush_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Validations val = new Validations();
            Console.WriteLine("Employee Management System");
          
            List<Employee> Emplist = new List<Employee>();
            while(true)
            {
                
              
                Console.WriteLine("1. List all Employees " + "\n" +
                                  "2. Add an Employee " + "\n" +
                                  "3. Edit Employee " + "\n" +
                                  "4. Delete Employee " + "\n" +
                                  "5. Send mail to Employee " + "\n" +
                                  "6. BroadCast notification " + "\n" +
                                  "7. Export data to csv " + "\n" +
                                  "8. Qut Application " + "\n" );

                Console.WriteLine("Please enter in range of 1 to 8");
                int input = val.CheckId();
                switch (input)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Show Employee List");
                            ListAllEmployee.Details(Emplist);
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Add Operation");
                            Add_Employee add = new Add_Employee();
                            add.Add(Emplist);
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Edit edit = new Edit();
                            Console.WriteLine("Edit Operation");
                            edit.EditEmployee(Emplist);
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("Delete Operation");
                            DeleteEmp delete = new DeleteEmp();
                            delete.Delete(Emplist);
                            break;
                        }
                    case 5:
                        {   
                            Console.Clear();
                            Console.WriteLine("Send Email");
                            SendEmail email = new SendEmail();
                            email.Send(Emplist);
                            break;
                        }
                    case 6:
                        {
                            Console.Clear();
                            Console.WriteLine("BroadCast Email");
                            BroadCastEmail broadCast = new BroadCastEmail();
                            broadCast.BroadCast(Emplist);
                            break;
                        }
                    case 7:
                        {
                            Console.Clear();
                            Console.WriteLine("Export Operation");
                            Export export = new Export();
                            export.ExportCsv(Emplist);
                            break;
                        }
                    case 8:
                        {
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Please provide a valid input in range of 1 to 8");
                            Console.WriteLine();
                            break;
                        }
                }
            }
        }
    }
}
