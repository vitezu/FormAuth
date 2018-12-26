using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FormAuth.Models
{
    public class UserContext : DbContext
    {
        public UserContext() :
        base("DefaultConnection")
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }

    public class UserDbInitializer : DropCreateDatabaseAlways<UserContext>
    {
        protected override void Seed(UserContext context)
        {
            Role admin = new Role { Id = 1, Name = "admin" };
            Role user = new Role { Name = "user", Id = 2 };
            context.Roles.Add(admin);
            context.Roles.Add(user);
            context.Users.Add(new User {
                Email = "user@mail.com",
                Age = 23,
                Password = "user",
                RoleId = 1 });

            base.Seed(context);
        }
    }
}