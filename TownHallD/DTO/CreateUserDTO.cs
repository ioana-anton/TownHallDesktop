using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TownHallD.DTO
{
    public class CreateUserDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public CreateUserDTO() { }

        public CreateUserDTO(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }

    }
}
