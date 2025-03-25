using Microsoft.AspNetCore.Mvc;

namespace COMP003B.LectureActivity2.Controllers
{
    public class ProfileController : Controller
    {
        // Profile/About 
        [HttpGet]
        public IActionResult About()
        {
            return View();
        }

        // Profile/Hobbies
        [HttpGet]
        public IActionResult Hobbies()
        {
            return View();
        }
    }
}
