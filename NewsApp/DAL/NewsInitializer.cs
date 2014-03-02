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
            var news = new List<News>
            {
                new News{Title="1 HOLY FUCKSICLES ITS RAINING MEN", Text="There isn't really anything to add There isn't really anything to add There isn't really anything to add There isn't really anything to add There isn't really anything to add There isn't really anything to add There isn't really anything to add There isn't really anything to add", Category="News", PostDate=DateTime.Now},
                new News{Title="2 HOLY FUCKSICLES ITS RAINING MEN", Text="There isn't really anything to add", Category="News", PostDate=DateTime.Now},
                new News{Title="3 HOLY FUCKSICLES ITS RAINING MEN", Text="There isn't really anything to add", Category="News", PostDate=DateTime.Now},
                new News{Title="4 HOLY FUCKSICLES ITS RAINING MEN", Text="There isn't really anything to add", Category="News", PostDate=DateTime.Now},
                new News{Title="5 HOLY FUCKSICLES ITS RAINING MEN", Text="There isn't really anything to add", Category="News", PostDate=DateTime.Now},
                new News{Title="6 HOLY FUCKSICLES ITS RAINING MEN", Text="There isn't really anything to add", Category="News", PostDate=DateTime.Now},
                new News{Title="7 HOLY FUCKSICLES ITS RAINING MEN", Text="There isn't really anything to add", Category="News", PostDate=DateTime.Now},
                new News{Title="8 HOLY FUCKSICLES ITS RAINING MEN", Text="There isn't really anything to add", Category="News", PostDate=DateTime.Now},
                new News{Title="9 HOLY FUCKSICLES ITS RAINING MEN", Text="There isn't really anything to add", Category="News", PostDate=DateTime.Now},
                new News{Title="10 HOLY FUCKSICLES ITS RAINING MEN", Text="There isn't really anything to add", Category="News", PostDate=DateTime.Now},
                new News{Title="11 HOLY FUCKSICLES ITS RAINING MEN", Text="There isn't really anything to add", Category="News", PostDate=DateTime.Now},
                new News{Title="12 HOLY FUCKSICLES ITS RAINING MEN", Text="There isn't really anything to add", Category="News", PostDate=DateTime.Now},
                new News{Title="13 HOLY FUCKSICLES ITS RAINING MEN", Text="There isn't really anything to add", Category="News", PostDate=DateTime.Now},
                new News{Title="14 HOLY FUCKSICLES ITS RAINING MEN", Text="There isn't really anything to add", Category="News", PostDate=DateTime.Now},
            };
            news.ForEach(s => context.News.Add(s));
            context.SaveChanges();
        }
    }
}