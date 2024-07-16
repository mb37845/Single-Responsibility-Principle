using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Single_Responsibility_Principle
{
    class ManagmentMenue
    {
        public static bool OperationsMenu(User user,List<User> users, string filePath, string filepathIncomes, string filepathExpense)
        {


                DisplayMessage.ManagementMenu();
                string ManagementOption = Console.ReadLine();
                if (ManagementOption == "1" || ManagementOption == "2")
                {
                    User.SetUserId(users, user);
                    string fileNow = "";
                    string type = "";
                    if (ManagementOption == "1")
                    {
                        fileNow = filepathIncomes;
                        type = "income";
                        user.transaction = FileOperation.ReadTrnasFromTxt(fileNow, user.id, type);
                    }

                    if (ManagementOption == "2")
                    {
                        fileNow = filepathExpense;
                        type = "Expense";
                        user.transaction = FileOperation.ReadTrnasFromTxt(fileNow, user.id, type);
                    }

                    DisplayMessage.TransactionOperationMenu();
                    string TransOption = Console.ReadLine();


                    if (TransOption == "1")
                    {
                        OperationsOnTransaction.View(user, type);
                    }

                    else if (TransOption == "2")
                    {
                        OperationsOnTransaction.AddTransaction(type, fileNow, user);
                    }

                    else if (TransOption == "3")
                    {
                        OperationsOnTransaction.DeLeteTransaction(type, fileNow, user);
                    }

                    else if (TransOption == "4")
                    {
                        OperationsOnTransaction.Filter(user.transaction);
                    }

                    else
                    {
                        ErrorMessages.WrongOption();
                        return false;
                    }


                }

                else if (ManagementOption == "3")
                {
                    OperationsOnTransaction.GenerateReport(filepathIncomes, filepathExpense, user);
                }

                else
                { return false; }


                Console.WriteLine("Do you want to exit (yes / no)?");
                string answer = Console.ReadLine();

                if (answer.ToLower() == "yes")
                {
                    return true;
                }

                else 
                {
                    return false;
                }
                
        }
    }
}
