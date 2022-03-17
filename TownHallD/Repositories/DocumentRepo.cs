using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TownHallD.DataAccess;
using TownHallD.Entities;

namespace TownHallD.Repositories
{
    public class DocumentRepo
    {
        private readonly DatabaseContext databaseContext;

        public DocumentRepo(DatabaseContext dbContext)
        {
            this.databaseContext = dbContext;
        }

        public async Task InsertNewDocument(Document doc)
        {
            databaseContext.Documents.Add(doc);
            await databaseContext.SaveChangesAsync();
        }

        public async Task DeleteDocument(Document document)
        {
            databaseContext.Documents.Remove(databaseContext.Documents.Single(a => a.Id.Equals(document.Id) == true));
            databaseContext.Requests.Remove(databaseContext.Requests.Single(a => a.Document == document));
            await databaseContext.SaveChangesAsync();
        }

        public async Task<List<Document>> GetAllDocuments()
        {
            var docs = databaseContext.Documents.ToList();
            return docs;
        }
    }
}
