using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TownHallD.Entities;

namespace TownHallD.DTO
{
    public class RequestDTO
    {
        public String Id { get; set; }
        public String State { get; set; }
        public House House { get; set; }
        public User User { get; set; }
        public Document Document { get; set; }
    }
}
