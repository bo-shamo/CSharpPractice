using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method = 'post' >" +
                 "<input type='text' name = 'name' />" +
                 "<label for = 'lang'> Choose a Language:</label>" +
                 "<select id='lang' name = 'lang'>" +
                 "<option value = ''> --Please Choose a Language--</option>" +
                 "<option value = 'english'>English</option>" +
                "<option value = 'french'>French</option>" +
                "<option value = 'german'>German</option>" +
                "<option value = 'spanish'>Spanish</option>" +
                "<option value = 'japanese'>Japanese</option>" +
                "</select>" +
                 "<input type='submit' value='Greet me!' />" +
                 "</form>";

            return Content(html,"text/html");
        }

        // /Hello
        [Route("/Hello")]
        [HttpPost]
        public IActionResult Display(string name = "World", string lang = "english")
        {
            string greeting;
            switch (lang)
            {
                case "french":
                    greeting = "Bonjour";
                    break;
                case "german":
                    greeting = "Guten Tag";
                    break;
                case "spanish":
                    greeting = "Hola";
                    break;
                case "japanese":
                    greeting = "Kon'nichiwa";
                    break;
                default:
                    greeting = "Hello";
                    break;
            }
            return Content(string.Format("<h1>{0} {1}</h1>", greeting, name), "text/html");
        }

        //Handle requests to /Hello/Chris (URL segement)
        [Route("/Hello/{name}")]
        public IActionResult Index2(string name)
        {
            return Content(string.Format("<h1>Hello {0}</h1>", name), "text/html");
        }

        

        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }
    }
}
