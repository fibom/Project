using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace WEB_Library.Models
{
    public class LibraryInitializer : DropCreateDatabaseAlways<BookContext>
    {

        protected override void Seed(BookContext db)
        {
            db.Library.Add(new Libraries { Title = "War and Peace", Author = "L.Tolstoy", Price = 220 });
            db.Library.Add(new Libraries { Title = "Fathers and children", Author = "I.Turgenev", Price = 180 });
            db.Library.Add(new Libraries { Title = "Seagull", Author = "A.Chekhov", Price = 150 });

            base.Seed(db);
        }
    }
}