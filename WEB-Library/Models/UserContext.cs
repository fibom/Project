using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WEB_Library.Models
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public void AddUser(User user)
        {
            Users.Add(user);
            SaveChanges();
        }

    }
}