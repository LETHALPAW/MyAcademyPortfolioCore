using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;

namespace Portfolio.Web.Controllers
{
	public class StatisticsController (PortfolioContext context): Controller
	{
		public IActionResult Index()
		{
			ViewBag.projectsCount = context.Projects.Count();
			ViewBag.skillAverage = context.Skillls.Any()	? context.Skillls.Average(x => x.Percentage).ToString("00.00"):0.ToString("00.00");
			ViewBag.unreadMessages = context.UserMessages.Count(x=>x.IsRead==false);
			ViewBag.lastMessageOwner = context.UserMessages.OrderByDescending(x=>x.UserMessageId).Select(x=>x.Name).FirstOrDefault();

			var startYear = context.Experiances.Min(x => x.StartYear);

			ViewBag.experienceYear = DateTime.Now.Year - startYear;

			ViewBag.companyCount = context.Experiances.Select(x => x.Company).Count();

			ViewBag.ReviewCount = context.Testimonials.Any()? context.Testimonials.Average(x=>x.Review).ToString("00.00"):"Değerlendirme Yok";

			ViewBag.maxReviewOwner = context.Testimonials.OrderByDescending(x=>x.Review).Select(x=>x.Name).FirstOrDefault();

			ViewBag.minReviewOwner = context.Testimonials.OrderBy(x=>x.Review).Select(x=>x.Name).FirstOrDefault();

			return View();
		}
	}
}
