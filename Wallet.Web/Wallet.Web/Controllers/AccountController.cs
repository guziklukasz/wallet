using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Wallet.Web.Controllers
{
    public partial class AccountController : Controller
    {
        // GET: Account
        public virtual ActionResult Index()
        {
            return View();
        }

        public virtual ActionResult Login()
        {
            return View();
        }
    }
}