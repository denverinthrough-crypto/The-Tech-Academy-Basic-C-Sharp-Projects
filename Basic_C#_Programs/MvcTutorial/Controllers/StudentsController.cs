using Microsoft.AspNetCore.Mvc;

namespace MvcTutorial.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
