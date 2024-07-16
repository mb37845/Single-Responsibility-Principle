using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Single_Responsibility_Principle
{
    class FileOperation
    {
        public static void WriteToFile(string filePath, string line)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(line);


            }
        }

        public static List<User> ReadUsersData(string filePath)
        {
            string username;
            string password;
            string email;
            int id;
            string line;
            string[] values;
            List<User> users = new List<User>();
            using (var reader = new StreamReader(filePath))
            {

                while ((line = reader.ReadLine()) != null)
                {
                    values = line.Split(',');
                    if (values.Length == 4)
                    {

                        users.Add(new User(id = Convert.ToInt32(values[0].Trim()), username = values[1].Trim(), password = values[2].Trim(), email = values[3].Trim()));
                    }
                }

            }


            return users;
        }

        public static List<Transaction> ReadTrnasFromTxt(string filePath, int id, string type)
        {
            DateTime date;
            double amount;
            string source;
            List<Transaction> transaction = new List<Transaction>();
            using (var reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var values = line.Split(',');


                    if (values.Length == 4)
                    {
                        if (Convert.ToInt32(Convert.ToInt32(values[0].Trim())) == id)
                        {

                            transaction.Add(new Transaction(date = DateTime.ParseExact(values[3].Trim(), "dd-MM-yyyy", null), amount = Convert.ToDouble(values[2].Trim()), source = values[1].Trim(), type));
                        }
                    }
                }

            }


            return transaction;
        }
    }
}
