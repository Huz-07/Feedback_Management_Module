using System.Collections.Generic;
using System.Web.Mvc;
using FeedbackManagement.Models;

namespace FeedbackManagement.Controllers
{
    public class FeedbackController : Controller
    {
        public ActionResult Index()
        {
            return View(new Feedback());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                List<Feedback> feedbackList =
                    Session["FeedbackList"] as List<Feedback>;

                if (feedbackList == null)
                {
                    feedbackList = new List<Feedback>();
                }

                feedbackList.Add(feedback);
                Session["FeedbackList"] = feedbackList;

                TempData["Message"] =
                    "Feedback submitted successfully!";

                return RedirectToAction("Index");
            }

            return View(feedback);
        }
    }
}
