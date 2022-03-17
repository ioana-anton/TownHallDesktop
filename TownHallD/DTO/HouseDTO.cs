using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TownHallD.Entities;

namespace TownHallD.DTO
{
    public class HouseDTO
    {
        public String Id { get; set; }
        public String Address { get; set; }
        public String Type { get; set; }
        public User User { get; set; }
    }
}
