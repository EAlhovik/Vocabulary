using System.Web.Mvc;
using Vocabulary.Controllers.Base;
using Vocabulary.Data.Contracts;

namespace Vocabulary.Controllers
{
    public class VocabularyController : BaseController
    {
        
        public VocabularyController(IVocabularyUow vocabularyUow)
        {
            MvcApplication.VocabularyUow  = vocabularyUow;
        }
        public ActionResult Index()
        {
            return View();
        }

    }
}
