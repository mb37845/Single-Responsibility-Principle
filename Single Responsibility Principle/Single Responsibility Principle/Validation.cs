using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Single_Responsibility_Principle
{
    class Validation
    {
        public static bool ValidateEmail(string email)
        {
             string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

             if (Regex.IsMatch(email, emailPattern))
                  {
                     return true;
                  }
             else
                  {
                    return false;
                  }
              
           
        }

        public static bool ValidatePassword(string password)
        {

            string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";

       
            if (Regex.IsMatch(password, passwordPattern))
            {
               return true;
            }
            else
            {
                return false;
            }
        
           
        }

        public static bool CheckExistens(List<User> users, User user , string type)
        {
            for (int i = 0; i < users.Count(); i++) 
            {
                if (users[i].name == user.name)
                {
                    if (type == "login") 
                    {
                        if (users[i].password == user.password)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    return true;
                }

            }

            return false;
            
            
        }
    }
}
