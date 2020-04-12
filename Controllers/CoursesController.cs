using Microsoft.AspNetCore.Mvc;

namespace MyCourse.Controllers
{
    public class CoursesController : Controller
    {
        
        public IActionResult Index()
        {
            return Content("Sono nella Index");

        }

        public IActionResult Detail(string Id)
        {

            return Content($"sono detail e ho ricevuto l'id {Id}");
        }

        public IActionResult Detailosti(string Id)
        {

            return Content($"sono detail e ho ricevuto l'id {Id}");
        }

    }
}