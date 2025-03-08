using Microsoft.AspNetCore.Mvc;

namespace projectStructureG02.controllers
{
    public class MoviesControllar:Controller
    {

        public IAcceptedResult Index(int?id)
        {
            //return " Hello Route :) ";
            //ContentResult result = new ContentResult();
            //result.Content = "BLack Adam";
            //result.ContentType = "object/pdf";
            //return result;

            return Content("Hello Route","Text/HTML");
        }

        public IAcceptedResult Hamada()
        {
            //RedirectResult result= new RedirectResult("http://localhost:43051/Movies/Index");            
            return RedirectToAction(nameof(Index));
        }

        public IAcceptedResult GetMovie(int id ,string name,Movie movie)
        //public IAcceptedResult GetMovie(int[] arr )
        {
            //return Content($"{arr[0]}");
            return Content($"Movie Id: {movie.Id} ::: with Name:{movie.Name}");

        }
    }
}
