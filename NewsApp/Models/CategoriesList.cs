using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace System.Web.Mvc
{
    public class cate
    {
        public string CatId { get; set; }
        public string Name { get; set; }
    }
    public class CategoriesList
    {
        public static IEnumerable<cate> Items = new List<cate> {
        new cate {
            CatId = "Politics",
            Name = "Politics"
        },
        new cate {
            CatId = "News",
            Name = "News"
        },
        new cate {
            CatId = "Sports",
            Name = "Sports"
        },
        new cate {
            CatId = "Education",
            Name = "Education"
        }
    };
    }
}