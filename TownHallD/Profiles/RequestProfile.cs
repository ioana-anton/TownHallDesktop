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
    public class RequestProfile : Profile
    {
        public RequestProfile()
        {
            CreateMap<Request, RequestDTO>();
            CreateMap<RequestDTO, Request>();
            CreateMap<CreateRequestDTO, Request>();
            CreateMap<Request, CreateRequestDTO>();
        }

    }
}
