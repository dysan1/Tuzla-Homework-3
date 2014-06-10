using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuzla_Homework_3
{

    class Student
    {

        public string name, lastName, email, location;

        public bool getFullName()
        {
            if (name.Length < 2)
            {
                Console.WriteLine("Name must be at least two characters long");
                return false;
            }

            if (!name.All(Char.IsLetter))
            {
                Console.WriteLine("Name can only have letters");
                return false;
            }


            if (name.Substring(0, 1) == name[0].ToString().ToUpper())
                return true;
            else
            {
                Console.WriteLine("Name must start with an uppercase letter");
                return false;
            }
        }



        public bool getLastName()
        {
            if (lastName.Length < 2)
            {
                Console.WriteLine("Last name must be at least two characters long");
                return false;
            }

            if (!lastName.All(Char.IsLetter))
            {
                Console.WriteLine("Last name can only have letters");
                return false;
            }


            if (lastName.Substring(0, 1) == lastName[0].ToString().ToUpper())
                return true;
            else
            {
                Console.WriteLine("Last name must start with an uppercase letter");
                return false;
            }

        }

        public bool getEmail()
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                Console.WriteLine("Wrong format!");
                return false;
            }
        }

        public bool getLocation()
        {
            if (location == "sarajevo" || location == "tuzla" || location == "Sarajevo" || location == "Tuzla" || location == "TZ" || location == "SA")
                return true;
            else
            {
                Console.WriteLine("Invalid location. Only Sarajevo and Tuzla are accepted.");
                return false;
            }
        }


        public string getStudentInfo()
        {
            return "Student " + name + " " + lastName + " from " + location + " with email " + email;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Student me = new Student();
            me.name = "Sandy";
            me.lastName = "Smajic";
            me.email = "sysc1223@aubih.edu.ba";
            me.location = "Tuzla";

            Console.WriteLine(me.getStudentInfo());

            Student s = new Student();
            Console.WriteLine("Enter name:");
            s.name = Console.ReadLine();

            while (!s.getFullName())
                s.name = Console.ReadLine();

            Console.WriteLine("Enter last name:");
            s.lastName = Console.ReadLine();
           
            while (!s.getLastName())
                s.lastName = Console.ReadLine();
           
            char c = (char)Console.Read();
            if (char.IsUpper(c))
            {
                Console.WriteLine("The character is uppercase");
            }
            else
                Console.WriteLine("The character is lowercase");
            

            Console.WriteLine("Enter email address:");
            s.email = Console.ReadLine();

            while (!s.getEmail())
                s.email = Console.ReadLine();

            Console.WriteLine("Enter location:");
            s.location = Console.ReadLine();

            while (!s.getLocation())
                s.location = Console.ReadLine();

            Console.WriteLine(s.getStudentInfo());
            Console.ReadLine();
        }
    }
}
