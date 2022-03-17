using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TownHallD.Entities
{
    public class Request
    {
        public String Id { get; set; } = Guid.NewGuid().ToString();
        public String State { get; set; } = new string("PENDING");
        public House House { get; set; }
        public User User { get; set; }
        public Document Document { get; set; }
        //public DateTime Date { get; set; }
    }
}
