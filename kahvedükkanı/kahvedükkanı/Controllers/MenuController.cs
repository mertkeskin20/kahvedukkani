using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using kahvedükkanı.Models.Siniflar;
namespace kahvedükkanı.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        Context context = new Context();
        public ActionResult Index()
        {
            var degerler = context.Menus.ToList();
            return View(degerler);
        }
        
    }
}