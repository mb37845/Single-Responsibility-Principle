using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Single_Responsibility_Principle
{
    class ErrorMessages
    {
        public static void WrongPassword() {
            Console.WriteLine("The Password is wrong!");
        }

        public static void WrongUserName()
        {
            Console.WriteLine("The user name is wrong!");
        }

        public static void WrongEmail()
        {
            Console.WriteLine("The Email is wrong!");
        }

        public static void WrongOption()
        {
            Console.WriteLine("There is no option like that!");
        }

        public static void WrongSign()
        {
            Console.WriteLine("Failed to sign up!");
        }

        public static void WrongLog()
        {
            Console.WriteLine("Failed to login!");
        }
    }
}
