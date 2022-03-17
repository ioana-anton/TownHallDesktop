using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TownHallD.Entities
{
    public class Document
    {
        public String Id { get; set; } = Guid.NewGuid().ToString();

        public String Type { get; set; }

        [JsonIgnore]
        public List<Request> Request { get; set; }

    }
}
