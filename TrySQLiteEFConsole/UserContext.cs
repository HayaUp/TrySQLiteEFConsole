using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.IO;

namespace TrySQLiteEFConsole
{
    internal class UserContext : DbContext
    {
        public string DbPath;
        public DbSet<User>? Users { get; set; }

        public UserContext()
        {
            string desktop_path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DbPath = $"{desktop_path}{Path.DirectorySeparatorChar}sample_database.db";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source={DbPath}");
        }
    }
}
