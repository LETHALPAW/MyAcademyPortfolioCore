using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;

namespace Portfolio.Web.ViewComponents.Default_Index
{
	public class _DefaultLoginComponent(PortfolioContext context) : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var userlogin = context.UserLogins.ToList();
			return View(userlogin);
		}

	}
}
