using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Single_Responsibility_Principle
{
    class DisplayMessage
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("*** Welcome To This Page *** ");
        }

        public static void AuthMenu()
        {
            Console.WriteLine("1-Login\n2-Sign Up\n3-Logout\nChoose option:");

        }

        public static void SuccessSign()
        {
            Console.WriteLine("Sign Up Succefully");

        }

        public static void SuccessLogin()
        {
            Console.WriteLine("Log In Succefully");

        }

        public static void ManagementMenu()
        {
            Console.WriteLine("1-Income\n2-Expense\n3-Report\nChoose option:");

        }

        public static void TransactionOperationMenu()
        {
            Console.WriteLine("1-View\n2-Add\n3-Delete\n4-Filter\nChoose option:");

        }

        public static void SuccessAddOperation()
        {
            Console.WriteLine("The Record Added Succefully!");

        }

        public static void SuccessDeleteOperation()
        {
            Console.WriteLine("The Record Deleted Succefully");

        }

        
    }
}
