using Microsoft.AspNetCore.Mvc;

namespace GymManagmentSystem.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            int Data = 10;
            return View(Data);
        }
        public IActionResult Rowida(int id)
        {
            return View(id);
        }

    }
}
