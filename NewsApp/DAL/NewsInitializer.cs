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
                new News{Title="14 HOLY FUCKSICLES ITS RAINING MEN", Text="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis imperdiet dui et eros vulputate, quis lobortis augue ullamcorper. Fusce nec risus vel massa cursus volutpat. Donec bibendum, neque nec eleifend fermentum, neque elit aliquam dolor, et porta ipsum quam in erat. Ut ut nibh sapien. Sed tempor, sem in malesuada consectetur, lorem erat congue lorem, in gravida mi velit sit amet nisl. Morbi id porta sapien. Suspendisse sapien leo, pellentesque id pharetra a, pretium eget odio. Nunc sodales lobortis velit. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Donec lacus massa, pretium eget porta vel, pellentesque et massa. Proin pulvinar nec ante quis fermentum. Vivamus ultricies felis sed facilisis pellentesque. Quisque convallis metus est, id feugiat diam faucibus quis. Donec sed euismod metus.", Category="News", PostDate=DateTime.Now},
            };
            news.ForEach(s => context.News.Add(s));
            context.SaveChanges();
        }
    }
}