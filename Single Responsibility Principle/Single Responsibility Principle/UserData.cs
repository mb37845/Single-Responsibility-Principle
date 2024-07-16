using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Single_Responsibility_Principle
{
    class UserData
    {

        public static String[] getDataForLogin()
        {
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();
            
            return new String[]{ name, password };
            
        
        }

        public static String[] getDataForSignup()
        {
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();
            Console.WriteLine("Enter Email: ");
            string email = Console.ReadLine();

            return new String[] { name, email , password };


        }

        
    }
}
