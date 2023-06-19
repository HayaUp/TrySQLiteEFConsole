using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrySQLiteEFConsole
{
    public class Prefecture
    {
        public int PrefectureId { get; set; }
        public string Name { get; set; }
        public List<Prefecture> Prefectures { get; }

        public Prefecture()
        {
            Prefectures = new List<Prefecture>();
        }
    }
}
