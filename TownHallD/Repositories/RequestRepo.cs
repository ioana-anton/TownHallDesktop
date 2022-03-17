using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TownHallD.DataAccess;
using TownHallD.DTO;
using TownHallD.Entities;

namespace TownHallD.Repositories
{
    public class RequestRepo
    {
        private readonly DatabaseContext databaseContext;

        public RequestRepo(DatabaseContext dbContext)
        {
            databaseContext = dbContext;
        }

        public async Task DeleteRequest(Request request)
        {
            databaseContext.Requests.Remove(databaseContext.Requests.Single(a => a.Id.Equals(request.Id) == true));
            await databaseContext.SaveChangesAsync();
        }

        public async Task UpdateRequest(Request request, String house, String document)
        {
            // request.House = databaseContext.Houses.Where(a => a.Address.Equals(house)).FirstOrDefault();
            // request.Document = databaseContext.Documents.Where(a => a.Type.Equals(document)).FirstOrDefault();
            await DeleteRequest(databaseContext.Requests.Where(a => a.Id.Equals(request.Id)).FirstOrDefault());
            await InsertNewRequest(request, request.User.Id, house, document);
            await databaseContext.SaveChangesAsync();
        }

        public async Task<List<Request>> GetAllRequests()
        {
            var reqs = databaseContext.Requests.ToList();
            return reqs;
        }

        public async Task InsertNewRequest(Request request, String idUser, String address, String doctype)
        {


            request.User = await databaseContext.Users.FindAsync(idUser);
            request.House = (House)databaseContext.Houses.Where(a => a.Address.Equals(address)).FirstOrDefault();
            request.Document = (Document)databaseContext.Documents.Where(a => a.Type.Equals(doctype)).FirstOrDefault();

            databaseContext.Requests.Add(request);
            await databaseContext.SaveChangesAsync();
        }
    }
}
