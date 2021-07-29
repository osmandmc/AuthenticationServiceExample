using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using AuthenticationServiceExample.ViewModel;
using AuthenticationServiceExample;
using AuthenticationServiceExample.Operations;
using AuthenticationServiceExample.Domain;

namespace AuthenticationServiceExample.Repository
{
    public class UserRepository
    {
        static List<User> users = new List<User>
        {
            new User {userName = "Ege", password = "c2lmcmUxMjM0JUQzPT8h"}, //sifre1234
            new User {userName = "Ahmet", password = "aXN0YW5idWwlRDM9PyE="} //istanbul
        };
        public static User GetUser(string _userName, string _password)
        {
            foreach(User user in users)
            {
                if(user.password == _password && user.userName == _userName)
                {
                    return user;
                }
            }
            return null;
        }

    }
}
