using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsApp.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "About the site";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "If in trouble, please feel free to contact us";

			return View();
		}
	}
}