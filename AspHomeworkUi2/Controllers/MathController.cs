using Microsoft.AspNetCore.Mvc;

namespace AspHomeworkUi2.Controllers
{
    public class MathController : Controller
    {
        public IActionResult Add(int x,int y)
        {
            int result = x + y;
            return View(result as object);
        }
        public IActionResult Mul(int x, int y)
        {
            int result = x * y;
            return View(result as object);
        }
        public IActionResult Div(int x, int y)
        {
            int result = x / y;
            return View(result as object);
        }
        public IActionResult Sub(int x, int y)
        {
            int result = x - y;
            return View(result as object);
        }
    }
}
