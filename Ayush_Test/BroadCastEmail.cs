using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ayush_Test
{
    public class BroadCastEmail
    {
        Validations val = new Validations();
        public void BroadCast(List<Employee>emp_list)
        {
            Console.WriteLine();
            Console.WriteLine("Please Enter Subject");
            string subject = val.ValidSubject(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Please Enter Message");
            string body = val.ValidMessage(Console.ReadLine());
            Console.WriteLine();
            Smtp message = new Smtp();
            foreach(Employee emp in emp_list)
            {
                Thread thread = new Thread(() => message.SendEmail(emp.Email, subject, body));

                thread.Start();
                thread.Join();
            }
            Console.WriteLine();
            Console.WriteLine("Message BroadCast Success");
            Console.WriteLine();
        }
    }
}
