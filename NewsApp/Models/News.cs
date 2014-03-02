using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewsApp.Models
{
    public class News
    {
        //This class contains all the variables that are later put into the database.  The required fields make sure that the following cannot be NULL.
        //We got a bit confused with the casing conventions and ended up making a bit of a hash out of these.  Would be better if they were all lowercase.
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Text { get; set; }
        public string Category { get; set; }
        public DateTime PostDate = DateTime.Now;
    }
}