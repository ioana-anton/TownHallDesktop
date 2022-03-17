using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TownHallD.DTO;
using TownHallD.Entities;
using TownHallD.Repositories;

namespace TownHallD.Services
{
    public class DocumentService
    {
        private readonly DocumentRepo _documentRepo;
        private readonly IMapper _mapper;

        public DocumentService(DocumentRepo documentRepo, IMapper mapper)
        {
            _documentRepo = documentRepo;
            _mapper = mapper;
        }

        public async Task InsertDocument(CreateDocumentDTO document)
        {
            if (document.Type == String.Empty) throw new ArgumentNullException();
            else
            {
                var doc = _mapper.Map<Document>(document);
                await _documentRepo.InsertNewDocument(doc);
            }
        }

        public async Task DeleteDocument(DocumentDTO document)
        {
            if (document == null) throw new ArgumentNullException();
            else
            {
                var doc = _mapper.Map<Document>(document);
                await _documentRepo.DeleteDocument(doc);
            }

        }

        public async Task<List<DocumentDTO>> ShowDocuments()
        {
            var docs = await _documentRepo.GetAllDocuments();
            if (docs == null) return null;
            else return _mapper.Map<List<DocumentDTO>>(docs);

        }
    }
}
