using System.Web.Mvc;
using Vocabulary.Controllers.Base;
using Vocabulary.Data.Contracts;

namespace Vocabulary.Controllers
{
    public class VocabularyController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

    }
}
