using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Local_Noticeboard_Mvc.Controllers
{
    public class DashboardController : Controller
    {
        [Authorize]
        // GET: Dashboard
        public ActionResult Index()
        {
            return View();
        }
    }
}