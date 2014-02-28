using NewsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsApp.DAL
{
    public class NewsInitializer :System.Data.Entity. DropCreateDatabaseIfModelChanges<NewsContext>
    {
        protected override void Seed(NewsContext context)
        {
            var news = new List<News>
            {
                new News{Title="HOLY FUCKSICLES ITS RAINING MEN", Text="There isn't really anything to add", Category="News", PostDate=DateTime.Now},
                new News{Title="HOLY FUCKSICLES ITS RAINING MEN", Text="There isn't really anything to add", Category="News", PostDate=DateTime.Now},
                new News{Title="HOLY FUCKSICLES ITS RAINING MEN", Text="There isn't really anything to add", Category="News", PostDate=DateTime.Now},
                new News{Title="HOLY FUCKSICLES ITS RAINING MEN", Text="There isn't really anything to add", Category="News", PostDate=DateTime.Now},
                new News{Title="HOLY FUCKSICLES ITS RAINING MEN", Text="There isn't really anything to add", Category="News", PostDate=DateTime.Now},
                new News{Title="HOLY FUCKSICLES ITS RAINING MEN", Text="There isn't really anything to add", Category="News", PostDate=DateTime.Now},
                new News{Title="HOLY FUCKSICLES ITS RAINING MEN", Text="There isn't really anything to add", Category="News", PostDate=DateTime.Now},
            };
            news.ForEach(s => context.News.Add(s));
            context.SaveChanges();
        }
    }
}