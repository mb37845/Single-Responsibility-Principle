using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Single_Responsibility_Principle
{
    class User
    {
        public string name {get;set;}
        public string email { get; set;}
        public string password { get; set; }
        public int id { get; set; }
        public List<Transaction> transaction = new List<Transaction>();
        
        


        public User(int userId ,string userName, string userEmail,string userPassword)
        {
            name = userName;
            email = userEmail;
            id = userId;
            password = userPassword;
            


        }

        public User(string userName,string userPassword)
        {
            name = userName;
            password = userPassword;
            


        }

        public static void SetUserId(List<User> users,User user)
        {
            int Aid = -1;
            for (int i = 0; i < users.Count(); i++)
            {
                if (users[i].name == user.name)
                {
                    Aid = users[i].id;

                }
            }

            user.id = Aid;
          
        }
       
    }
}
