using Microsoft.AspNetCore.Mvc;
using LearningManagment.Core.Constants;

namespace LearningManagment.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = Constants.HOME_PAGE;
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
