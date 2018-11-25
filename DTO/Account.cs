using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
            public string UserName { get; set; }
            public string Password { get; set; }
            public Account(string userName, string password)
            {
                UserName = userName;
                Password = password;
            }
    }
}
