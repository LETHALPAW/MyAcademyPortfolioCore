using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;

namespace Portfolio.Web.ViewComponents.Default_Index
{
	public class _DefaultSkillsComponent(PortfolioContext context) : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var skills = context.Skillls.ToList();
			return View(skills);

		}
	}
}
