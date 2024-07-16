using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Single_Responsibility_Principle
{
    class OperationsOnTransaction
    {


        public static void AddTransaction(string type, string filePath, User user)
        {
            
            Console.Write("Date: ");
            string date = Console.ReadLine();
            Console.Write("Amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            Console.Write("Source: ");
            string source = Console.ReadLine();
            if (date == "" || amount < 0 || source == "")
            {
                Console.WriteLine("Invalid inputs. You need to enter a date(dd-MM-yyyy),source and amount that is not less than 0 ");
            }
            Transaction singleTransaction = new Transaction(DateTime.ParseExact(date, "dd-MM-yyyy", null), amount, source, type);
            user.transaction.Add(singleTransaction);
            string line = user.id + "," + singleTransaction.source + "," + singleTransaction.amount + "," + singleTransaction.date.ToShortDateString();
            FileOperation.WriteToFile(filePath,line);
            DisplayMessage.SuccessAddOperation();
            
        }


        public static void DisplaySignleTransaction(Transaction transaction)
        {
            Console.WriteLine(transaction.date.ToShortDateString() + "   " + transaction.amount + "   " + transaction.source);

        }


        public static void View(User user,string type)
        {
            Console.WriteLine("Date       Amount       Source");
            for (int i = 0; i < user.transaction.Count(); i++)
            {
                if (user.transaction[i].type == type)
                {
                    Console.Write((i+1) + ". ");
                    OperationsOnTransaction.DisplaySignleTransaction(user.transaction[i]);
                  
                }

            }

        }

        
        public static void DeLeteTransaction(string type,string filePath, User user) 
        {
            OperationsOnTransaction.View(user,type);
            List<string> lines = new List<string>(File.ReadAllLines(filePath));
            Console.Write("Choose the number of " + type + " you want to delete: ");
            int del = Convert.ToInt32(Console.ReadLine());
            user.transaction.RemoveAt(del-1);
            lines.RemoveAt(del);
            File.WriteAllLines(filePath, lines);
            DisplayMessage.SuccessDeleteOperation();
        }


        


        public static void Filter(List<Transaction> transactions)
        {
            Console.WriteLine("Enter the source you want: ");
            string source = Console.ReadLine();
            var filteredTranaction = transactions.Where(i => i.source.Equals(source, StringComparison.OrdinalIgnoreCase)).ToList();
            var totalTransaction = filteredTranaction.Sum(i => i.amount);

            Console.WriteLine("Report for ", source);
            Console.WriteLine("Total: ", source, "/n");

            foreach (var transaction in filteredTranaction)
            {
                Console.WriteLine(transaction.date.ToShortDateString(), " - ", transaction.amount);
            }
        }


        


        public static void GenerateReport(string filepathIncomes, string filepathExpense,User user)
        {
            Console.Write("Enter the start date (dd-MM-yyyy): ");
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
            Console.Write("Enter the end date (dd-MM-yyyy): ");
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
            List<Transaction> incomes = FileOperation.ReadTrnasFromTxt(filepathIncomes, user.id, "income");
            List<Transaction> expenses = FileOperation.ReadTrnasFromTxt(filepathExpense, user.id, "expense");
            incomes.AddRange(expenses);

            var filteredIncomes = incomes.Where(i => i.date >= startDate && i.date <= endDate && i.type == "income").ToList();
            var filteredExpenses = incomes.Where(e => e.date >= startDate && e.date <= endDate && e.type == "expense").ToList();

            var totalIncome = filteredIncomes.Sum(i => i.amount);
            var totalExpenses = filteredExpenses.Sum(e => e.amount);
            var netSavings = totalIncome - totalExpenses;

            Console.WriteLine("Report from " + startDate.ToShortDateString() + " to " + endDate.ToShortDateString());
            Console.WriteLine("Total Income: " + totalIncome);
            Console.WriteLine("Total Expenses: " + totalExpenses);
            Console.WriteLine("Net Savings: " + netSavings, "\n");

            Console.WriteLine("Income Breakdown by Category:");
            var incomeByCategory = filteredIncomes.GroupBy(i => i.source)
                                                   .Select(g => new { Category = g.Key, Amount = g.Sum(i => i.amount) });
            foreach (var item in incomeByCategory)
            {
                Console.WriteLine(item.Category + " " + item.Amount);
            }

            Console.WriteLine("\nExpense Breakdown by Category:");
            var expenseByCategory = filteredExpenses.GroupBy(e => e.source)
                                                    .Select(g => new { Category = g.Key, Amount = g.Sum(e => e.amount) });
            foreach (var item in expenseByCategory)
            {
                Console.WriteLine(item.Category + " " + item.Amount);
            }
        }

    }
}
