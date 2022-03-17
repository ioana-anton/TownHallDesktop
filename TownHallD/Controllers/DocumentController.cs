using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TownHallD.DTO;
using TownHallD.Entities;
using TownHallD.Services;

namespace TownHallD.Controllers
{
    public class DocumentController
    {
        private readonly DocumentService _documentService;

        public DocumentController(DocumentService documentService)
        {
            _documentService = documentService;
        }

        public async Task AddDocument(CreateDocumentDTO document)
        {
            try
            {
                await _documentService.InsertDocument(document);
            }
            catch (Exception ex)
            {
                throw new Exception(Utils.Constants.ErrorMessages.INSERT_DOCUMENT_ERROR_MESSAGE);
            }

        }

        public async Task RemoveDocument(DocumentDTO document)
        {
            try
            {
                await _documentService.DeleteDocument(document);
            }
            catch (ArgumentNullException ex)
            {
                throw new Exception(Utils.Constants.ErrorMessages.DELETE_DOCUMENT_ERROR_MESSAGE);
            }

        }

        public async Task<List<DocumentDTO>> ShowDocument()
        {
            try
            {
                var res = await _documentService.ShowDocuments();

                return res;
            }
            catch (Exception ex)
            {

                throw new Exception(Utils.Constants.ErrorMessages.INSERT_DOCUMENT_ERROR_MESSAGE);
            }

        }
    }
}
