using ColumbiaTennisLadder.ViewModels;
using System.Web.Mvc;

namespace ColumbiaTennisLadder.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {            
            return View();
        }

        [HttpGet]
        public ActionResult RecommendFeature()
        {          
            var recomendationViewModel = new RecommendFeatureViewModel();

            return View(recomendationViewModel);

        }

        [HttpPost]
        public ActionResult RecommendFeature(RecommendFeatureViewModel recomendation)
        {
            ViewBag.Title = "Recommend a feature";

            return View();

        }
    }
}