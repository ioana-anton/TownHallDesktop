using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TownHallD.DTO
{
    public class CreateDocumentDTO
    {
        public String Type { get; set; }

        public CreateDocumentDTO() { }

        public CreateDocumentDTO(String type)
        {
            Type = type;
        }
    }
}
