using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TownHallD.Entities
{
    public class House
    {
        public String Id { get; set; } = Guid.NewGuid().ToString();
        public String Address { get; set; }
        public String Type { get; set; }
        public User User { get; set; } = null;

        [JsonIgnore]
        public List<Request> Requests { get; set; }
    }
}
