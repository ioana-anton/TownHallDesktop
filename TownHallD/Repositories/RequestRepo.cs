using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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

        public async Task UpdateRequestAdmin(Request request, String state)
        {
            // request.House = databaseContext.Houses.Where(a => a.Address.Equals(house)).FirstOrDefault();
            // request.Document = databaseContext.Documents.Where(a => a.Type.Equals(document)).FirstOrDefault();
            await DeleteRequest(databaseContext.Requests.Where(a => a.Id.Equals(request.Id)).FirstOrDefault());
            await InsertNewRequest(request, request.User.Id, request.House.Address, request.Document.Type, state);
            //request.State = state;
            //databaseContext.Entry(request).Property("State").IsModified = true;
            await databaseContext.SaveChangesAsync();
        }

        public async Task<List<Request>> GetAllRequests()
        {
            var reqs = databaseContext.Requests.Include(r => r.User).Include(r => r.Document).Include(r => r.House).ToList();
            return reqs;
        }

        public async Task<List<Request>> GetSortedRequestsByDate()
        {

            var reqs = databaseContext.Requests.Include(r => r.User).Include(r => r.Document).Include(r => r.House).ToList().OrderBy(item => item.Date);
            return reqs.ToList<Request>();
        }

        public async Task<List<Request>> SelectLikeRequests(String s)
        {
            var reqs = databaseContext.Requests.Where(r => r.Id.Contains(s))
                .Include(r => r.User)
                .Include(r => r.Document)
                .Include(r => r.House)
                .ToList();
            return reqs;
        }

        public async Task InsertNewRequest(Request request, String idUser, String address, String doctype, String State = null)
        {
            var resq = databaseContext.Requests.Where(d => d.Date.Year == DateTime.Now.Year).Where(x => x.User.Id.Equals(idUser)).Include(r => r.User).Include(r => r.Document).Include(r => r.House).ToList();
            if (resq.Count >= 3) throw new Exception();
            request.User = await databaseContext.Users.FindAsync(idUser);
            request.House = (House)databaseContext.Houses.Where(a => a.Address.Equals(address)).FirstOrDefault();
            request.Document = (Document)databaseContext.Documents.Where(a => a.Type.Equals(doctype)).FirstOrDefault();
            request.Date = DateTime.Now;
            if (State != null)
                request.State = State;
            Console.WriteLine(request.Date);
            databaseContext.Requests.Add(request);
            await databaseContext.SaveChangesAsync();
        }
    }
}
