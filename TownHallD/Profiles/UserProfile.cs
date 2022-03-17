using AutoMapper;
using TownHallD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TownHallD.DTO;

namespace TownHallD.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDTO>();
            CreateMap<CreateUserDTO, User>();
            CreateMap<User, LoginUserDTO>();
        }
    }
}
