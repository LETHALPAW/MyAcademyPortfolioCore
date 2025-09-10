using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;
using Portfolio.Web.Entities;

namespace Portfolio.Web.Controllers
{
	public class SkillController(PortfolioContext context) : Controller
	{
		public IActionResult Index()
		{
			var skill = context.Skillls.ToList();
			return View(skill);
		}

		public IActionResult CreateSkill()
		{
			return View();
		}

		[HttpPost]
		public IActionResult CreateSkill(Skill skill)
		{
			context.Skillls.Add(skill);
			context.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult EditSkill(int id)
		{
			var skill = context.Skillls.Find(id);
			return View(skill);
		}

		[HttpPost]
		public IActionResult EditSkill(Skill skill)
		{
			context.Skillls.Update(skill);
			context.SaveChanges();
			return RedirectToAction("Index");
		}


		public IActionResult DeleteSkill(int id)
		{
			var skill = context.Skillls.Find(id);
			context.Skillls.Remove(skill);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
