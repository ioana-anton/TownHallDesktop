using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TownHallD.Entities
{
    public class User
    {

        public String Id { get; set; } = Guid.NewGuid().ToString();

        public String Name { get; set; }

        public String Email { get; set; }

        public String Password { get; set; }

        public bool IsAdmin { get; set; } = false;

        [JsonIgnore]
        public List<House> Houses { get; set; }

        [JsonIgnore]
        public List<Request> Requests { get; set; }


    }
}
