using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ayush_Test
{
    public class Validations
    {
        public string CheckName(string userName)
        {
            string namePattern = @"^[A-Za-z\s]+$";
            while (!Regex.IsMatch(userName, namePattern))
            {
                Console.WriteLine("Error: Please enter your name again.");
                userName = Console.ReadLine();
            }
            return userName;
        }
 
        public string CheckDept(string dept)
        {
                string pattern = @"^[a-zA-Z0-9\s\-_']{2,50}$";
                while(!Regex.IsMatch(dept, pattern))
                {
                        Console.WriteLine("Error : Please Provide Department again.");
                        dept = Console.ReadLine();
                }
                    return dept;
        }
        public string CheckDob(string dob)
        {
            DateTime dateOfBirth;
            while (!DateTime.TryParse(dob, out dateOfBirth))
            {
                Console.WriteLine("Error: Invalid date of birth");
                dob = Console.ReadLine();
            }
            return dateOfBirth.Date.ToString("d");
        }
       


    public string CheckEmail(string email)
        {
            // Define a regular expression for email validation
            string pattern = @"^([a-z0-9_\-\.]+)@((\[[0-9]{1,3}" +
             @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
             @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            while (!Regex.IsMatch(email, pattern))
            {
                Console.WriteLine("Error: Please provide email again. ");
                email = Console.ReadLine();
            }
            return email;
        }

    public double CheckSalary(string sal)
        {
            double salary;
            while(!double.TryParse(sal, out salary))
            {
                Console.WriteLine("Error: Please Provide Valid Salary");
                sal= Console.ReadLine();
            }
            return salary;
        }
     public string CheckHobby(string hobby)
        {
            string pattern = @"^[a-zA-Z0-9\s]+$";
            while (!Regex.IsMatch(hobby, pattern))
            {
                Console.WriteLine("Error : Please Provide Department again.");
                hobby = Console.ReadLine();
            }
            return hobby;
        }
    
        public int CheckId()
        {
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Error: Enter a valid Id");
            }
            return id;
        }
        public string ValidMessage(string message)
        {
            while (true)
            {
                if (message == null || message.Length == 0)
                {
                    Console.WriteLine("Please provide Message");
                    message = Console.ReadLine();
                }
                else if (message.Length > 1000)
                {
                    Console.WriteLine("Message is to Big");
                    message = Console.ReadLine();
                }
                {
                    return message;
                }
            }
        }
        public string ValidSubject(string message)
        {
            while (true)
            {
                if (message == null || message.Length == 0)
                {
                    Console.WriteLine("Please provide Subject");
                    message = Console.ReadLine();
                }
                else if (message.Length > 50)
                {
                    Console.WriteLine("Subj");
                    message = Console.ReadLine();
                }
                {
                    return message;
                }
            }
        }
      
    }
}
