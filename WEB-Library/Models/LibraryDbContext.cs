using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WEB_Library.Models
{
    public class LibraryDbContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        public LibraryDbContext() : base("DefaultConnection") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}