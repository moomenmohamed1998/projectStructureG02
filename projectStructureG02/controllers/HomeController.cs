using Microsoft.AspNetCore.Mvc;

namespace projectStructureG02.controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Movie movie = new Movie();
            {
                movie.Id = 1;
                movie.Name = "Black Adam";  
            }

            return View();
            //return View(movie);
            //return View("IndexOfHome");

        }
    }
}
