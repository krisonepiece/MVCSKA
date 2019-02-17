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
			var type = Enumerable.Range(1, 2).OrderBy(n => n * n * (new Random()).Next());

			var record = new List<IndexViewModel>
			{
				new IndexViewModel() {Type = AccountingType.Outlay, Date = DateTime.Now, Amount = 1200, Remark = "First"},
				new IndexViewModel() {Type = AccountingType.Income, Date = DateTime.Now, Amount = 2000, Remark = "Second"}
			};

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
	}
}