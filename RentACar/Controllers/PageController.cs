using Microsoft.AspNetCore.Mvc;

namespace RentACar.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
