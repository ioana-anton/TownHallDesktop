using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TownHallD.DTO;
using TownHallD.Services;

namespace TownHallD.Controllers
{
    public class HouseController
    {
        private readonly HouseService _houseService;

        public HouseController(HouseService houseService)
        {
            _houseService = houseService;
        }

        public async Task AddHouse(CreateHouseDTO house, String idUser)
        {
            try
            {

                await _houseService.InsertHouse(house, idUser);
            }
            catch (ArgumentNullException ex)
            {

                throw new Exception(Utils.Constants.ErrorMessages.INSERT_HOUSE_ERROR_MESSAGE);
            }

        }

        public async Task RemoveHouse(HouseDTO house)
        {
            try
            {
                await _houseService.DeleteHouse(house);
            }
            catch (ArgumentNullException ex)
            {
                throw new Exception(Utils.Constants.ErrorMessages.DELETE_HOUSE_ERROR_MESSAGE);
            }

        }

        public async Task<List<DisplayHouseDTO>> ShowHouse(String id)
        {
            try
            {
                var res = await _houseService.ShowHouses(id);

                return res;
            }
            catch (Exception ex)
            {

                throw new Exception(Utils.Constants.ErrorMessages.SELECT_HOUSES_ERROR_MESSAGE);
            }
        }
    }
}
