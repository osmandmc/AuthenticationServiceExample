using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using AuthenticationServiceExample.Controllers;
using AuthenticationServiceExample.Domain;
using AuthenticationServiceExample.Repository;
namespace AuthenticationServiceExample.Operations
{
    public class TokenOperations
    {
        public string SendToken(string username, string password)
        {
            using Aes myAes = Aes.Create();

            byte[] bytes = AESOperations.EncryptStringToBytes_Aes(password, myAes.Key, myAes.IV);

            string token = Convert.ToBase64String(bytes);

            User user = UserRepository.GetUser(username, password);

            if(user != null)
            {
                return token;
            }
            else
            {
                return null;
            }
        }
    }
}
