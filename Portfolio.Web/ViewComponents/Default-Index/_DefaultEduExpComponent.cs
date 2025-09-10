using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;

namespace Portfolio.Web.ViewComponents.Default_Index
{
	public class _DefaultEduExpComponent(PortfolioContext context) : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			ViewBag.education = context.Educations.ToList();
			ViewBag.experience = context.Experiances.ToList();
			return View();
		}
	}
}
