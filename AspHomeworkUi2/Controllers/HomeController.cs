using Microsoft.AspNetCore.Mvc;
using NuGet.Packaging;

namespace AspHomeworkUi2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string url1 = Url.Action("Add", "Math", new { x = 1, y = 2 });
            string url2 = Url.Action("Mul", "Math", new { x = 2, y = 2 });
            string url3 = Url.Action("Sub", "Math", new { x = 5, y = 2 });
            string url4 = Url.Action("Div", "Math", new { x = 10, y = 2 });

            string[] url = new string[4] { url1, url2, url3, url4 };
            return View(url as object);
        }
    }
}
