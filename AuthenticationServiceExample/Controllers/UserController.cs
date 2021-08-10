using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Cryptography;
using AuthenticationServiceExample.ViewModel;
using AuthenticationServiceExample.Repository;
using AuthenticationServiceExample.Domain;
using AuthenticationServiceExample.Operations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AuthenticationServiceExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        UserRepository userRepository = new UserRepository();
        Encryption encryption = new Encryption();
        string salt = "%D3=?!";
        [HttpPost]
        public string Login(LoginModel loginModel)
        {
            loginModel.Password += salt;
            User user = UserRepository.GetUser(loginModel.UserName, Base64Operations.Encode(loginModel.Password));
            return encryption.SendToken(user);
        }
    }
}