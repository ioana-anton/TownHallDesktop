using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TownHallD.Entities;

namespace TownHallD.DTO
{
    public class CreateHouseDTO
    {

        public String Address { get; set; }
        public String Type { get; set; }

        public CreateHouseDTO() { }

        public CreateHouseDTO(String address, String type)
        {
            Address = address;
            Type = type;
        }

    }
}
