using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;
using Portfolio.Web.Entities;

namespace Portfolio.Web.Controllers
{
	public class ExperienceController : Controller
	{
		private readonly PortfolioContext _context;

		public ExperienceController(PortfolioContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			var experience = _context.Experiances.ToList();
			return View(experience);
		}

		public IActionResult CreateExperience()
		{
			return View();
		}

		[HttpPost]
		public IActionResult CreateExperience(Experiance experience)
		{ 
			_context.Add(experience);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult DeleteExperience(int id)
		{
			var experience = _context.Experiances.Find(id);
			_context.Experiances.Remove(experience);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult EditExperience(int id)
		{
			var experience = _context.Experiances.Find(id);
			return View(experience);
		}
		[HttpPost]
		public IActionResult EditExperience(Experiance experience)
		{
			_context.Update(experience);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}

	}
}
