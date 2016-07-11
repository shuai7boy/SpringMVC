using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpringMVC.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        public string AdminService { get; set; }
        public ActionResult Index()
        {
            return Content(AdminService);
        }

    }
}
