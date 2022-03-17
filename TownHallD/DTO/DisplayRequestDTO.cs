using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TownHallD.DTO
{
    public class DisplayRequestDTO
    {
        public String Id { get; set; }
        public String State { get; set; }
        public String House { get; set; }
        public String User { get; set; }
        public String Document { get; set; }

        public DisplayRequestDTO() { }
        public DisplayRequestDTO(String id, String state, String house, String user, String document)
        {
            Id = id;
            State = state;
            House = house;
            User = user;
            Document = document;
        }
    }
}
