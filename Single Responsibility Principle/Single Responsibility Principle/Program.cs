using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Single_Responsibility_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // load user data
                List<User> users = new List<User>();
                
                string filePath = @"users_db.txt";
                string filepathIncomes = @"Incomes.txt";
                string filepathExpense = @"Expense.txt";
                users = FileOperation.ReadUsersData(filePath);

                // start the program
                DisplayMessage.WelcomeMessage();
                DisplayMessage.AuthMenu();
                string option = Console.ReadLine();

                while (true)
                {
                    if (option == "1")
                    {
                        bool continue_ = true;
                        User user = Authentication.Login(users, filePath);
                        while (continue_ && user.name != null)
                        {

                            bool flag = ManagmentMenue.OperationsMenu(user, users, filePath, filepathIncomes, filepathExpense);

                            if (flag)
                            {
                                continue_ = false;
                                Authentication.logout();
                                return;
                            }


                        }
                    }

                    else if (option == "2")
                    {

                        Authentication.SighUp(users, filePath);

                    }

                    else if (option == "3")
                    {
                        Authentication.logout();
                        return;
                    }

                    else 
                    { 
                       ErrorMessages.WrongOption();
                       return;
                    }


                }









            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

        
    }
}
