using System;
using System.Collections.Generic;
using System.Linq;

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
                //var user = db.Users.Find(1);
                //Console.WriteLine(user.Name);

                // Update
                //user.Name = $"Super {user.Name}";
                //db.SaveChanges();

                // Delete
                //db.Remove(user);
                //db.SaveChanges();

                AddDummyUsers(db);

                //var users = db.Users.Where(user => user.UserId % 2 == 0);

                //foreach(var user in users)
                //{
                //    Console.WriteLine(user.Name);
                //}
            }
        }

        static void AddDummyUsers(UserContext db)
        {
            //var user = new User();

            var names = new[]
            {
                "Alice",
                "Bob",
                "Carol",
                "Charlie",
                "Dave",
                "Ellen",
                "Frank",
                "Gari",
                "Haiku",
                "Issac",
                "Ivan",
                "Justin",
                "Katana",
                "Last",
                "Mallory",
                "Marvin",
                "Mallet",
                "Matilda",
                "Ninja",
                "Oscar",
                "Pat",
                "Peggy",
                "Plod",
                "Quantum",
                "Ramen",
                "Steve",
                "Trent",
                "Trudy",
                "Udon",
                "Victor",
                "Walter",
                "Xanadu",
                "Yakitori",
                "Zoe",
            };

            var users = new List<User>();

            for(int i = 0; i < names.Length; i++)
            {
                //// 本来の使い方ではない
                //// ナビゲーションプロパティの使い方が違う
                //user.Users.Add(new User { UserId = i + 1, Name = names[i] });
                users.Add(new User { UserId = i + 1, Name = names[i] });
            }

            db.AddRange(users);
            db.SaveChanges();
        }
    }
}
