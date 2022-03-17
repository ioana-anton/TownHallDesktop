using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TownHallD.DTO;
using TownHallD.Entities;

namespace TownHallD.Profiles
{
    public class DocumentProfile : Profile
    {
        public DocumentProfile()
        {
            CreateMap<Document, DocumentDTO>();
            CreateMap<Document, CreateDocumentDTO>();
            CreateMap<CreateDocumentDTO, Document>();
            CreateMap<DocumentDTO, Document>();
        }
    }
}
