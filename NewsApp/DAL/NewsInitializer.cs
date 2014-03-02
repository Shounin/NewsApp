using NewsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsApp.DAL
{
    public class NewsInitializer :System.Data.Entity. DropCreateDatabaseAlways<NewsContext>
    {
        protected override void Seed(NewsContext context)
        {
            //This was used to initialize the database but it is no longer being used.
            var news = new List<News>
            {
                new News{Title="HOLY CRAP ITS RAINING MEN", Text="There isn't really anything to add There isn't really anything to add There isn't really anything to add There isn't really anything to add There isn't really anything to add There isn't really anything to add There isn't really anything to add There isn't really anything to add", Category="News", PostDate=DateTime.Now},
            };
            news.ForEach(s => context.News.Add(s));
            context.SaveChanges();
        }
    }
}