using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsApp.Models
{
    public class News
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Category { get; set; }
        public DateTime PostDate = DateTime.Now;
    }
}