using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TownHallD.DataAccess;
using TownHallD.Entities;

namespace TownHallD.Repositories
{
    public class UserRepo
    {
        private readonly DatabaseContext databaseContext;

        public UserRepo(DatabaseContext dbContext)
        {
            databaseContext = dbContext;
        }

        public async Task<User> GetUserById(string id)
        {
            var user = await databaseContext.Users.FindAsync(id);
            return user;
        }

        public async Task InsertNewUser(User user)
        {
            if (user == null) throw new ArgumentNullException("user");
            else
                databaseContext.Users.Add(user);
            await databaseContext.SaveChangesAsync();
        }

        public async Task<User> GetUserByLogin(string username, string password)
        {
            var byLogin = databaseContext.Users.Where(x => x.Password == password && (x.Email == username || x.Name == username)).First();
            return byLogin;
        }

        public async Task<List<User>> GetAllUsers()
        {
            var users = databaseContext.Users.ToList();
            return users;
        }
    }
}

