using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrySQLiteEFConsole
{
    public class User
    {
        public int Id;
        public string Name;
        public List<User> Users;

        public User()
        {
            Users = new List<User>();
        }
    }
}
