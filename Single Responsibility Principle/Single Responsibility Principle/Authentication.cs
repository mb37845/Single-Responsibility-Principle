using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Single_Responsibility_Principle
{
    class Authentication
    {
        public static bool loggedInUser;
        public static void SighUp(List<User> users, string filePath)
        {

            string[] userData = UserData.getDataForSignup();
            bool validEmail = Validation.ValidateEmail(userData[1]);
            bool validPass = Validation.ValidatePassword(userData[2]);
            User user = new User(users.Count() + 1, userData[0], userData[1], userData[2]);
            bool validExis = Validation.CheckExistens(users, user,"sign");
            
            if (validEmail && validPass && !validExis)
            {
                users.Add(user);
                string line = user.id + "," + user.name + "," + user.email + "," + user.password;
                FileOperation.WriteToFile(filePath, line);
                DisplayMessage.SuccessSign();
                
            }

            else
            {
                ErrorMessages.WrongSign();
            }


            


        }

        public static User Login(List<User> users, string filePath)
        {
            string[] userData = UserData.getDataForLogin();
            User user = new User(userData[0], userData[1]);
            bool validExis = Validation.CheckExistens(users, user,"login");
            if (validExis)
            {
                DisplayMessage.SuccessLogin();
                
                loggedInUser = true;
                
            }
            else
            {
                ErrorMessages.WrongLog();
                user.name= null;
                user.password = null;
               
            }
            return user;

        }


        public static void logout() 
        {
            loggedInUser = false;
            Console.WriteLine("You have been logged out.");        
        }
    }
}
