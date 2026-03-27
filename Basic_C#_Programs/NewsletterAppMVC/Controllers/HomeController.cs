using Microsoft.AspNetCore.Mvc;
using NewsletterAppMVC.Models;
using System.Diagnostics;

namespace NewsletterAppMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(string firstName, string lastName, string emailAddress)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml", new ErrorViewModel { RequestId = "Please fill in all fields." });
            }

            using (NewsletterContext db = new NewsletterContext())
            {
                var signup = new SignUp
                {
                    FirstName = firstName,
                    LastName = lastName,
                    EmailAddress = emailAddress
                };

                db.SignUps.Add(signup);
                db.SaveChanges();
            }

            return RedirectToAction("Index", "Admin");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}