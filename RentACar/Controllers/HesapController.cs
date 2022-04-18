using Microsoft.AspNetCore.Mvc;

namespace RentACar.Controllers
{
    public class HesapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Giris()
        {
            return View();
        }
        public IActionResult SifreSifirla()
        {
            return View();
        }
       
        public IActionResult Kayit()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Kayit(string usernamee)
        {
            string a = "Ali" + usernamee;
            return View(a);
        }
        public IActionResult Hukumvekosullar()
        {
            return View();
        }
    }
}
