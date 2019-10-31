using Microsoft.AspNetCore.Mvc;
namespace portfolio_I
{
    public class HomeController: Controller
    {
        //Requests
        //localhost:5000
        [HttpGet("")]
        public string Index()
        {
            return "This is my Index!";
        }

        //localhost:5000/hello
        [HttpGet("projects")]
        public string Projects()
        {
            return "These are my projects";
        }
        [HttpGet("contact")]
        public string Contact()
        {
            return "This is my Contact!";
        }
    }
}