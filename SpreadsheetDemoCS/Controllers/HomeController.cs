using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;
using SpreadsheetDemoCS.Models;

namespace SpreadsheetDemoCS.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			var model = new IndexModel();
			foreach(var i in Enumerable.Range(0,7))
			{
				model.Data.Add(new Models.SpreadsheetDataModel());
				model.Data[i].StringValue += $" - {i}";
			}
			return View(model);
		}
	}
}