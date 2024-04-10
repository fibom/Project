using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WEB_Library.Models
{
    public class ReadDbInitializer : DropCreateDatabaseAlways<ReadContext>
    {
        protected override void Seed(ReadContext db)
        {
            db.Reads.Add(new Read
            {
                Id = 1,
                Image1 = "~/Content/Images/11.jpg",
                Image2 = "~/Content/Images/12.jpg",
                Image3 = "~/Content/Images/13.jpg",
                Pdf1 = "~/Content/PDFs/11.pdf",
                Pdf2 = "~/Content/PDFs/12.pdf",
                Pdf3 = "~/Content/PDFs/13.pdf"
            });
            db.Reads.Add(new Read
            {
                Id = 2,
                Image1 = "~/Content/Images/1.jpg",
                Image2 = "~/Content/Images/9.jpg",
                Image3 = "~/Content/Images/14.jpg",
                Pdf1 = "~/Content/PDFs/1.pdf",
                Pdf2 = "~/Content/PDFs/9.pdf",
                Pdf3 = "~/Content/PDFs/14.pdf"
            });
            db.Reads.Add(new Read
            {
                Id = 3,
                Image1 = "~/Content/Images/15.jpg",
                Image2 = "~/Content/Images/16.jpg",
                Image3 = "~/Content/Images/17.jpg",
                Pdf1 = "~/Content/PDFs/15.pdf",
                Pdf2 = "~/Content/PDFs/16.pdf",
                Pdf3 = "~/Content/PDFs/17.pdf"
            });

            base.Seed(db);
        }
    }
}
