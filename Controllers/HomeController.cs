using Microsoft.AspNetCore.Mvc;
namespace portfolio_I
{
    public class HomeController: Controller
    {
        //Requests
        //localhost:5000
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        //localhost:5000/hello
        [HttpGet("projects")]
        public ViewResult Projects()
        {
            return View();
        }
        [HttpGet("contact")]
        public ViewResult Contact()
        {
            return View();
        }
    }
}