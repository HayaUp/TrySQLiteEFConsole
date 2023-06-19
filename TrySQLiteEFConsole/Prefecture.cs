using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrySQLiteEFConsole
{
    public class Prefecture
    {
        public int Id;
        public string Name;
        public List<Prefecture> Prefectures;

        public Prefecture()
        {
            Prefectures = new List<Prefecture>();
        }
    }
}
