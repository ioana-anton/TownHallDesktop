using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TownHallD.DataAccess;
using TownHallD.Entities;

namespace TownHallD.Repositories
{
    public class HouseRepo
    {
        private readonly DatabaseContext databaseContext;

        public HouseRepo(DatabaseContext dbContext)
        {
            this.databaseContext = dbContext;
        }

        public async Task<User> getUser(String id)
        {
            return await databaseContext.Users.FindAsync(id);
        }

        public async Task InsertNewHouse(House house, String idUser)
        {
            house.User = await getUser(idUser);
            databaseContext.Houses.Add(house);
            await databaseContext.SaveChangesAsync();
        }

        public async Task DeleteHouse(House house)
        {
            databaseContext.Houses.Remove(databaseContext.Houses.Single(a => a.Id.Equals(house.Id) == true));
            await databaseContext.SaveChangesAsync();
        }

        public async Task<List<House>> GetAllHouses()
        {
            var houses = databaseContext.Houses.ToList();
            return houses;
        }
    }
}
