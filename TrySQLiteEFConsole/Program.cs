using System;

namespace TrySQLiteEFConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new UserContext())
            {
                db.Add(new User { UserId = 1, Name = "Alice" });
                db.SaveChanges();
            }
        }
    }
}
