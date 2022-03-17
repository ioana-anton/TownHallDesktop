using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TownHallD.DataAccess;
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

        public async Task<List<Request>> GetAllRequests()
        {
            var reqs = databaseContext.Requests.ToList();
            return reqs;
        }
    }
}
