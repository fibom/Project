using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB_Library.Models
{
    public class Read
    {
        public int Id { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Pdf1 { get; set; }  // Добавляем поле для PDF файла
        public string Pdf2 { get; set; }  // Добавляем поле для PDF файла
        public string Pdf3 { get; set; }  // Добавляем поле для PDF файла
    }
}
