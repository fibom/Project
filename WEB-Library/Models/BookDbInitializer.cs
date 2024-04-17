using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace WEB_Library.Models
{
    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {

        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "War and Peace", Author = "L.Tolstoy", Price = 220 });
            db.Books.Add(new Book { Name = "Fathers and children", Author = "I.Turgenev", Price = 180 });
            db.Books.Add(new Book { Name = "Seagull", Author = "A.Chekhov", Price = 150 });

            base.Seed(db);
        }
    }
}