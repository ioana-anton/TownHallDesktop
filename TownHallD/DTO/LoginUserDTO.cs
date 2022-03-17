using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TownHallD.DTO
{
    public class LoginUserDTO
    {
        public string Username { get; set; }
        public String Password { get; set; }

        public LoginUserDTO() { }

        public LoginUserDTO(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
