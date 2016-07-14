using System.Web.Mvc;
using MVCDepInject.Models;

namespace MVCDepInject.Controllers
{
	public class HomeController : Controller
	{
		private IAccountManager accountManager;

		public HomeController(IAccountManager accountManager)
		{
			this.accountManager = accountManager;
		}

		public ActionResult Index()
		{
			return View();
		}

		public ActionResult NextAccounts(int startIndex, int accountsCount)
		{
			return PartialView(accountManager.GetNextAccounts(startIndex, accountsCount));
		}
	}
}