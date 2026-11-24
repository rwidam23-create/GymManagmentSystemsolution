using GymManagmentSystem.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymManagmentSystem.Controllers
{
    public class PlanController : Controller
    {
        private GymDBContext dBContext=new GymDBContext();
        public async Task<IActionResult> Index()
        {
            var plans =await dBContext.Plans.ToListAsync();
            return View(plans);
        }
    }
}
