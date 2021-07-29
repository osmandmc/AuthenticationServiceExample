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
            new User {loginModel = new LoginModel {UserName = "Ege", Password = "c2lmcmUxMjM0JUQzPT8h"}}, //sifre1234
            new User {loginModel = new LoginModel {UserName = "Ahmet", Password = "aXN0YW5idWwlRDM9PyE="}} //istanbul
        };

        public string SendToken(string username, string password)
        {
            using Aes myAes = Aes.Create();

            byte[] bytes = AESOperations.EncryptStringToBytes_Aes(password, myAes.Key, myAes.IV);

            string token = Convert.ToBase64String(bytes);
;
            foreach (User user in users)
            {
                if (user.loginModel.UserName == username && user.loginModel.Password == password)
                {
                    return token;
                }
            }
            return null;
        }
    }
}
