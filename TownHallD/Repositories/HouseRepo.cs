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


        public async Task InsertNewHouse(House house, String idUser)
        {
            house.User = await databaseContext.Users.FindAsync(idUser);
            databaseContext.Houses.Add(house);
            await databaseContext.SaveChangesAsync();
        }

        public async Task DeleteHouse(House house)
        {
            databaseContext.Houses.Remove(databaseContext.Houses.Single(a => a.Id.Equals(house.Id) == true));
            await databaseContext.SaveChangesAsync();
        }

        public async Task<List<House>> GetAllHouses(String id)
        {
            var houses = databaseContext.Houses.Where(a => a.User.Id.Equals(id)).ToList();
            return houses;
        }
    }
}
