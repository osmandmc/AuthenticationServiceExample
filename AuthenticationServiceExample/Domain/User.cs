using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticationServiceExample.ViewModel;

namespace AuthenticationServiceExample.Domain
{
    public class User
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
    }
}
