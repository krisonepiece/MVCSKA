using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSKA.Models.ViewModel;

namespace MVCSKA.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		[ChildActionOnly]
		public ActionResult AccountingList()
		{
			var DataCount = 50;

			var record = new List<IndexViewModel>();
			for (var i = 0; i < DataCount; i++)
			{
				record.Add(CreateRandomIndexViewModel());
			}

			return View(record);
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		private IndexViewModel CreateRandomIndexViewModel()
		{
			var rnd = new Random(Guid.NewGuid().GetHashCode());
			var value = Enum.GetValues(typeof(AccountingType));
			var start = new DateTime(2019, 1, 1);
			var range = (DateTime.Now - start).Days;
			return new IndexViewModel
			{
				Type = (AccountingType)value.GetValue(rnd.Next(value.Length)),
				Date = start.AddDays(rnd.Next(range)),
				Amount = rnd.Next(100, 10000),
				Remark = ""
			};
		}
	}
}