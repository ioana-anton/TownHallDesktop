using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TownHallD.DTO;
using TownHallD.Services;

namespace TownHallD.Controllers
{
    public class UserController
    {
        private readonly UserService _userService;
        public UserController(UserService userService)
        {
            _userService = userService;
        }

        public async Task<UserDTO> LoginUser(LoginUserDTO loginUserDTO)
        {

            var res = await _userService.LoginUser(loginUserDTO);

            if (res == null) throw new Exception();

            return res;
        }

        public async Task<UserDTO> CreateUser(CreateUserDTO createUserDTO)
        {
            var res = await _userService.CreateUser(createUserDTO);

            if (res.Name == String.Empty) throw new Exception();

            return res;
        }

        public async Task<List<UserDTO>> ShowUsers()
        {
            List<UserDTO> res = await _userService.ShowUsers();

            if (res == null) throw new Exception();

            return res;
        }
    }
}
