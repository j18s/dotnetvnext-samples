using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace LetsWriteCode.Controllers
{
    public class CodeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.message = "Welcome to Healthy Code magazine - November issue!";
            return View();
        }
    }
}
