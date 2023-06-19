using System;

namespace TrySQLiteEFConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new UserContext())
            {
                //// Insert
                //db.Add(new User { UserId = 1, Name = "Alice" });
                //db.SaveChanges();

                //// Select
                var user = db.Users.Find(1);
                //Console.WriteLine(user.Name);

                // Update
                //user.Name = $"Super {user.Name}";
                //db.SaveChanges();

                // Delete
                //db.Remove(user);
                //db.SaveChanges();
            }
        }
    }
}
