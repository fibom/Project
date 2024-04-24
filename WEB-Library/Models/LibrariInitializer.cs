using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace WEB_Library.Models
{
    public class LibrariInitializer : DropCreateDatabaseAlways<BookContext>
    {

        protected override void Seed(BookContext db)
        {
            db.Libraris.Add(new Librari { Name = "War and Peace1", Author = "L.Tolstoy1", Price = 220562 });
            db.Libraris.Add(new Librari { Name = "Fathers and children", Author = "I.Turgenev", Price = 180 });
            db.Libraris.Add(new Librari { Name = "Seagull", Author = "A.Chekhov", Price = 150 });

            base.Seed(db);
        }
    }
}