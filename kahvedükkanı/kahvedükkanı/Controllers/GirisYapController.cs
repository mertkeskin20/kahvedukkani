using kahvedükkanı.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace kahvedükkanı.Controllers
{
    public class GirisYapController : Controller
    {
        // GET: GirisYap
        Context context = new Context();
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin admin)
        {
            var info = context.Admins.FirstOrDefault(x => x.Name == admin.Name && x.Password == admin.Password);
            if(info != null)
            {
                FormsAuthentication.SetAuthCookie(info.Password, false);
                Session["Name"] = info.Name.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "GirisYap");
        }
    }
}