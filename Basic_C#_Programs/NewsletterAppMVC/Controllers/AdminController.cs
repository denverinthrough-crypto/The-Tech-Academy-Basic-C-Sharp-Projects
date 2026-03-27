using Microsoft.AspNetCore.Mvc;
using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModels;

namespace NewsletterAppMVC.Controllers
{
    public class AdminController : Controller
    {
      
        public IActionResult Index()
        {
            using (NewsletterContext db = new NewsletterContext())
            {
                var signupVms = db.SignUps.Where(s => s.Removed == null).Select(s => new SignupVm
                {
                    Id = s.Id,
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                    EmailAddress = s.EmailAddress
                }).ToList();

                return View(signupVms);
            }
        }
        [HttpPost]
        public IActionResult Unsubscribe(int Id)
        {
            using (NewsletterContext db = new NewsletterContext())
            {
                var signup = db.SignUps.Find(Id);
                signup.Removed = DateTime.Now;
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}