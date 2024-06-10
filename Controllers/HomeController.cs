using Microsoft.AspNetCore.Mvc;
using gitActionsDemo.Models;

namespace gitActionsDemo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(sampleText message)
        {
            ViewBag.Message = message.Message;
            return View();
        }

    }
}
