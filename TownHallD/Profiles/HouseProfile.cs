using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TownHallD.DTO;
using TownHallD.Entities;

namespace TownHallD.Profiles
{
    public class HouseProfile : Profile
    {
        public HouseProfile()
        {
            CreateMap<House, CreateHouseDTO>();
            CreateMap<CreateHouseDTO, House>();
            CreateMap<House, HouseDTO>();
            CreateMap<HouseDTO, House>();
            CreateMap<House, DisplayHouseDTO>();
            CreateMap<DisplayHouseDTO, House>();
        }
    }
}
