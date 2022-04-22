using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentACar.Data;
using RentACar.Models;
using RentACar.ViewModel;
using System.Security.Claims;

namespace RentACar.Controllers
{
    public class HesapController : Controller
    {
        private readonly RentACarDBContext _context;
        public HesapController(RentACarDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Giris()
        {
            UserViewModel userViewModel = new UserViewModel();
            return View(userViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Giris([Bind("Email","Password")]UserViewModel userViewModel )
        {
            if (ModelState.IsValid)
            {
                ClaimsIdentity identity = null;
                bool isAuthenticated = false;
                User userr = await _context.Users.Include(k => k.Role).FirstOrDefaultAsync //userr istenen kullanıcı
                    (m => m.Email == userViewModel.Email && m.Password == userViewModel.Password);

                if (userr == null)
                {
                    ModelState.AddModelError("Hata1", "Kullanıcı Bulunamadı.");
                    return View();
                }
    
                identity = new ClaimsIdentity
                (new[]
                        {
                            new Claim(ClaimTypes.Sid,userr.UserID.ToString()),
                            new Claim(ClaimTypes.Email,userr.Email),
                            new Claim(ClaimTypes.Role,userr.Role.RoleName),
                        }, CookieAuthenticationDefaults.AuthenticationScheme
                );

                isAuthenticated = true;

                if (isAuthenticated)
                {
                    var claims = new ClaimsPrincipal(identity);
                    var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claims,

                        new AuthenticationProperties
                        {
                            IsPersistent = true,
                            ExpiresUtc = DateTime.Now.AddMinutes(60)
                        }

                        );

                    if (userr.Role.RoleName == "PasifKullanıcı")
                    {
                        return Redirect("~/Hesap/AktivasyonBilgilendirmesi");
                    }
                    else if (userr.Role.RoleName == "AktifKullanıcı")
                    {
                        return Redirect("~/Home/Index");
                    }

                    else if (userr.Role.RoleName == "Admin")
                    {
                        return Redirect("~/AdminAnaSayfa/Index");
                    }

                    //else if (userr.Role.RoleName == "User Passive")    /*loginn olurken user passive
                    //ise zaten daha baştan yönlendirme yapıldığı için buna gerek kalmadı*/
                    //{
                    //    return Redirect("~/Account/SignupInformationPage");
                    //}
                    else
                    {
                        return Redirect("~/Home/ErrorPage");
                    }

                }
            }
            return View(userViewModel);
        }
        public IActionResult SifreSifirla()
        {
            return View();
        }
        public IActionResult Kayit()
        {
            User user = new User();
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]  
        public async Task<IActionResult> Kayit([Bind("UserID", "Email", "Password",
            "PasswordRepeat", "FullName", "Surname", "MobileNO","RoleID")] User user)
        {
            user.RoleID = 1;
            User  x= await _context.Users.FirstOrDefaultAsync(a => a.Email == user.Email);
            if (x != null)
            {
                ModelState.AddModelError("Hata1","Bu e-postaya ait bir kullanıcı zaten var!");
            }
            if (ModelState.IsValid)  //müşteriden gelen bilgiler classa uygunsa devam et
            {
                await _context.AddAsync(user);
                await _context.SaveChangesAsync();
                
                Helpers.EpostaIslemleri.AktivasyonMailiGonder(user.Email);
                return RedirectToAction("AktivasyonBilgilendirmesi","Hesap");
                          
            }
            return View(user);
        }
        public IActionResult Hukumvekosullar()
        {
            return View();
        }
        public IActionResult Aktivasyon(string kkk)
        {
            string eposta = Helpers.Sifreleme.SifreyiCoz(kkk);
            User user=_context.Users.FirstOrDefault(a => a.Email == eposta);
            if (user != null)
            {
                user.RoleID = 2;
                _context.Users.Update(user);
                _context.SaveChanges();
            }
            return View();
        }
      
        public IActionResult AktivasyonBilgilendirmesi()
        {

            return View();
        }
    }
}
