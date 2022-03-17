using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TownHallD.Entities;

namespace TownHallD.DataAccess
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        //Definirea tabelelor

        // dotnet ef migrations add Classes
        // dotnet ef database drop
        // dotnet ef database update

        public DbSet<User> Users { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<House> Houses { get; set; }
    }
}
