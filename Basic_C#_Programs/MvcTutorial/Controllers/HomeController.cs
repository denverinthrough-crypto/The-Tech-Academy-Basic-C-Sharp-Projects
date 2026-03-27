using Microsoft.AspNetCore.Mvc;
using MvcTutorial.Models;
using System.Diagnostics;

namespace MvcTutorial.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            User user = new User();
            user.Id = 1;
            user.FirstName = "Jesse";
            user.LastName = "Johnson";
            user.Age = 32;

             

            return View(user);
        }

        public IActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Message = "Contact Page - Academy of Learning";
            return View();
        }

        public IActionResult Instructors(int id)

        {
            List<Instructor> instructors = new List<Instructor>
            {
                new Instructor
                {
                    Id = 1,
                    FirstName = "Rick",
                    LastName = "Ramen"
                },

                new Instructor
                {
                    Id = 2,
                    FirstName = "Brett",
                    LastName = "Calendar"
                },

                new Instructor
                {
                    Id = 3,
                    FirstName = "Adam",
                    LastName = "Smithsonian"

                }
            };

            
            return View(instructors);
        }

        public IActionResult Instructor(int id)
        {
            ViewBag.Id = id; 

            Instructor dayTimeInstructor = new Instructor
            {
                Id = 1,
                FirstName = "Erik",
                LastName = "Gross"
            };

            return View(dayTimeInstructor);
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
