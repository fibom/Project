using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WEB_Library.Models
{
    public class ReadContext : DbContext
    {
        public DbSet<Read> Reads { get; set; }

        public void AddRead(Read read)
        {
            Reads.Add(read);
            SaveChanges();
        }

    }
}