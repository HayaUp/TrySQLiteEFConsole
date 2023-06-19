using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrySQLiteEFConsole
{
    public class UserAddress
    {
        public int UserId;
        public int PrefectureId;
        public List<UserAddress> UserAddresses;

        public UserAddress()
        {
            UserAddresses = new List<UserAddress>();
        }
    }
}
