using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormAuth.Controllers
{
    public class HomeController : Controller
    {
        //[Authorize (Roles ="admin")]
        public string Index()
        {
            
             
            if (User.Identity.IsAuthenticated)
            {
                return "Ваш логин " + User.Identity.Name + User.Identity.AuthenticationType;
            }
            return "Пользователь не зарегистрирован";

        }

        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}