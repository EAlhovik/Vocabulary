using System.Web.Mvc;
using Vocabulary.Controllers.Base;

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
