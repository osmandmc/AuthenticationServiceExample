using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Cryptography;

using AuthenticationServiceExample.ViewModel;
using AuthenticationServiceExample.Repository;
using AuthenticationServiceExample.Operations;
namespace AuthenticationServiceExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        UserRepository userRepository = new UserRepository();
        TokenOperations tokenOperations = new TokenOperations();
        string salt = "%D3=?!";
        [HttpPost]
        public string Login(LoginModel loginModel)
        {
            loginModel.Password += salt;
            return tokenOperations.SendToken(loginModel.UserName, Base64Operations.Encode(loginModel.Password));
        }
    }

}
