using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WEB_Library.Models
{
    public class DatabaseInitializer : DropCreateDatabaseAlways<LibraryDbContext>
    {

        protected override void Seed(LibraryDbContext context)
        {
            context.People.Add(new Person { Name = "Alice", Password = "alicepassword" });
            context.People.Add(new Person { Name = "Bob", Password = "bobpassword" });
            context.SaveChanges();
        }
    }
}