using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movina
{
    internal class User
    {
        private string userN;
        private string email;
        private string pass;
        public string UserName
        {
            get;
            private set;
        }
        public string Email
        {
            get;
            private set;
        }
        public string Password
        {
            get;
            private set;
        }

        public User(string userN, string email, string pass)
        {
            UserName = userN;
            Email = email;
            Password = pass;
        }

        //public Resetpassword()
    }
}
