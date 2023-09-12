using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Temlateusing.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Loginaccount()
        {
            return View();
        }
        
        public ActionResult RegisterAccount()
        {
            return View();
        }


    }
}