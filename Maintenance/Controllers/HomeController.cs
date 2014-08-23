using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Maintenance.Models;

namespace Maintenance.Controllers
{
	public class HomeController : Controller
	{
		EntityContext context = new EntityContext();

		public ActionResult About()
		{
			return View();
		}

		public ActionResult Index()
		{
			var questions = context.Questions.ToList();
			return View(questions);
		}

		[HttpPost]
		public ActionResult SubmitForm(Response response)
		{
			//Save response to database
			context.Responses.Add(response);
			context.SaveChanges();

			return RedirectToAction("ShowResponse", response);
		}

		public ActionResult References()
		{
			return View();
		}

		public ActionResult Modal(int id, int response)
		{
			var modal = context.ModalResponses.SingleOrDefault(r => r.Question.QuestionId == id && r.AnswersValue.Contains(response.ToString()));
			return PartialView(modal);
		}

		public ActionResult ShowResponse(Response response)
		{
			return View(response);
		}

		public PartialViewResult Question(int id)
		{
			var question = context.Questions.Single(q => q.QuestionId == id);
			return PartialView(question);
		}
	}
}
