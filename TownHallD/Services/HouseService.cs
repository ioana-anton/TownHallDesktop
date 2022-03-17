using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TownHallD.DTO;
using TownHallD.Entities;
using TownHallD.Repositories;

namespace TownHallD.Services
{
    public class HouseService
    {
        private readonly HouseRepo _houseRepo;
        private readonly IMapper _mapper;

        public HouseService(HouseRepo houseRepo, IMapper mapper)
        {
            _houseRepo = houseRepo;
            _mapper = mapper;
        }

        public async Task InsertHouse(CreateHouseDTO house, String idUser)
        {
            if (house.Address == String.Empty) throw new ArgumentNullException();
            else
            {
                //Console.WriteLine("hawo from house_service uwu");
                // var res = _mapper.Map<House>(house); //ceva nu merge
                var res = new House();
                res.Address = house.Address;
                res.Type = house.Type;
                Console.WriteLine(res.Id);
                await _houseRepo.InsertNewHouse(res, idUser);
            }
        }

        public async Task DeleteHouse(HouseDTO house)
        {
            if (house == null) throw new ArgumentNullException();
            else
            {
                var res = _mapper.Map<House>(house);
                await _houseRepo.DeleteHouse(res);
            }

        }

        public async Task<List<DisplayHouseDTO>> ShowHouses()
        {
            var res = await _houseRepo.GetAllHouses();
            if (res == null) return null;
            else return _mapper.Map<List<DisplayHouseDTO>>(res);

        }
    }
}
