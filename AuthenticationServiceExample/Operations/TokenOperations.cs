using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using AuthenticationServiceExample.Controllers;
using AuthenticationServiceExample.Domain;
using AuthenticationServiceExample.Repository;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace AuthenticationServiceExample.Operations
{
    public class Encryption
    {
        public string SendToken(User user)
        {
            string jsonString = JsonSerializer.Serialize(user);

            using Aes myAes = Aes.Create();
            
            byte[] bytes = AESOperations.EncryptStringToBytes_Aes(jsonString, myAes.Key, myAes.IV);

            string token = Convert.ToBase64String(bytes);

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
