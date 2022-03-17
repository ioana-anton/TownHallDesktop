using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TownHallD.DTO;
using TownHallD.Entities;
using TownHallD.Repositories;
using TownHallD.Utils;

namespace TownHallD.Services
{
    public class UserService
    {
        private readonly UserRepo _userRepo;
        private readonly IMapper _mapper;

        public UserService(UserRepo userRepo, IMapper mapper)
        {
            _userRepo = userRepo;
            _mapper = mapper;
        }

        public async Task<UserDTO> GetUserById(string id)
        {
            var user = await _userRepo.GetUserById(id);
            return _mapper.Map<UserDTO>(user);
        }

        public async Task<UserDTO> CreateUser(CreateUserDTO createUserDTO)
        {
            var user = _mapper.Map<User>(createUserDTO);
            user.Password = Encryption.CreateMd5(user.Password);
            await _userRepo.InsertNewUser(user);
            return await GetUserById(user.Id);
        }

        /*
        public async Task<UserDTO> User(String id)
        {
            return await GetUserById(id);
        }*/

        public async Task<UserDTO> LoginUser(LoginUserDTO loginUserDTO)
        {
            loginUserDTO.Password = Encryption.CreateMd5(loginUserDTO.Password);
            var sth = await _userRepo.GetUserByLogin(loginUserDTO.Username, loginUserDTO.Password);
            if (sth != null) return _mapper.Map<UserDTO>(sth);
            return null;
        }

        public async Task<List<UserDTO>> ShowUsers()
        {
            var users = await _userRepo.GetAllUsers();
            //if (users == null) return null;
            return _mapper.Map<List<UserDTO>>(users);

        }
    }
}

