using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace System.Web.Mvc
{
    public class cate
    {
        public string catId { get; set; }
        public string name { get; set; }
    }
    public class CategoriesList
    {
        //this is a categories list made to populate the drop down menu for the create/edit functions..  Maybe id and Name could be the same?
        public static IEnumerable<cate> Items = new List<cate> {
        new cate {
            catId = "Politics",
            name = "Politics"
        },
        new cate {
            catId = "News",
            name = "News"
        },
        new cate {
            catId = "Sports",
            name = "Sports"
        },
        new cate {
            catId = "Education",
            name = "Education"
        }
    };
    }
}