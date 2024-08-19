using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part2_Q2
{
    internal class BasicAuthenticationService : IAuthenticationService
    {

        public bool AuthenticateUser(string username, string password)
        {
            if(username.Equals("admin") && password.Equals("password"))
            {
                return true;
            }
            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            if(username.Equals("admin") && role.Equals("admin"))
            {
                return true;
            }
            return false;
        }
    }
}
