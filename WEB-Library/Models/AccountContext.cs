using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WEB_Library.Models
{
    public class AccountContext : DbContext
    {
        public DbSet<Account> Account{ get; set; }
    }

    public class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}