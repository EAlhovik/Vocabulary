using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vocabulary.Data.Contracts;

namespace Vocabulary.Controllers
{
    public class HomeController : Controller
    {
        private IVocabularyUow vocabularyUow;
        public HomeController(IVocabularyUow vocabularyUow)
        {
            this.vocabularyUow = vocabularyUow;
        }
        public ActionResult Index()
        {
            var rt = vocabularyUow.Words.All().Count();

            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
