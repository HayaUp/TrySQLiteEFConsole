using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TrySQLiteEFConsole
{
    internal class UserContext : DbContext
    {
        public string DbPath;
        public DbSet<User>? Users;
        public DbSet<UserAddress>? UserAddresses;

        public UserContext()
        {
            DbPath = "sample_database.db";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source={DbPath}");
        }
    }
}
