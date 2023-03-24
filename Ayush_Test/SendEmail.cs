using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ayush_Test
{
    public class SendEmail
    {
        public void Send(List<Employee> list)
        {
            Validations val = new Validations();
            Smtp message = new Smtp();
            Console.WriteLine();
            Console.WriteLine("Please Enter ID");
            int Id = val.CheckId();
            Employee emp = list.Find(em => em.Id == Id);
            if (emp != null)
            {
                Console.WriteLine();
                Console.WriteLine("Please Enter Subject");
                string messageSubject = val.ValidSubject(Console.ReadLine());
                Console.WriteLine() ;
                Console.WriteLine("Please Enter Message");
                string messageBody = val.ValidMessage(Console.ReadLine());
                Console.WriteLine();
                string email = emp.Email;
                Thread thread = new Thread(() => message.SendEmail(email,  messageSubject,messageBody));
                thread.Start();
                thread.Join();
               
                Console.WriteLine("Email Send Success");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Id is not present");
                Console.WriteLine();
            }
        }
    }
}
