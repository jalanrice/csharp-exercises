using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace C3HelloMVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post'>" +
                "<input type='text' name='name' />" +
                "<select name='language'>" +
                "<option value='english' selected>English</option>" +
                "<option value='french'>French</option>" +
                "<option value='spanish'>Spanish</option>" +
                "<option value='german'>German</option>" +
                "<option value='klingon'>Klingon</option>" +
                "</select>" + 
                "<input type='submit' value='Greet me!' />" +
                "</form>";

            return Content(html, "text/html");
            //return Redirect("/Hello/Goodbye");   // redirect example
        }

        // POST
        [Route("/Hello")]
        [HttpPost]
        public IActionResult Display(string name, string language)
        {
            Dictionary<string, string> greetings = new Dictionary<string, string>
            {
                {"english", "Hello" },
                {"french", "Bonjour" },
                {"spanish", "Hola" },
                {"german", "Hallo" },
                {"klingon", "nuqneH" }
            };
            string greeting = greetings[language];
            return Content(string.Format("<marquee behavior='scroll' direction='left'>{0} {1}</marquee>", greeting, name), "text/html");
        }

        // Handle requests to /Hello/Jeff (URL segment)
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
