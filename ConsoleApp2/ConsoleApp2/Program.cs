using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class LoginSystem
    {
        static void Main(string[] args)
        {
            string userName;
            string passWord;
            string secondPassword;
            Console.WriteLine("\n");
            Console.WriteLine("Welcome to User Login System");
            Console.WriteLine("****************************");
            Console.WriteLine("\n");
            Console.WriteLine("Enter Username: ");
            userName=Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            passWord = Console.ReadLine();
            Console.WriteLine("Registration Succesful");
            Console.WriteLine("\n");
            Console.WriteLine("****************************");
            Console.WriteLine("Hello "+userName+". "+"Please enter your password: ");
            secondPassword = Console.ReadLine();

            if (passWord == secondPassword)
            {
                Console.WriteLine("You are logged in Succesfully");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Password is incorrect.");
            }
        }
    }
}
