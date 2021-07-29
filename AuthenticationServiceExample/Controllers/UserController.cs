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

        string salt = "%D3=?!";
        [HttpPost]
        public string Login(LoginModel loginModel)
        {
            UserRepository userRepository = new UserRepository();

            loginModel.Password += salt;
             
            return userRepository.SendToken(loginModel.UserName, Base64Operations.Encode(loginModel.Password));
        }
    }

}
