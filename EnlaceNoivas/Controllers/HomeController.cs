using EnlaceNoivas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EnlaceNoivas.ViewModels;

namespace EnlaceNoivas.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        //

        public dbContext db = new dbContext();
        public ActionResult Index()
        {
            IndexModel model = new IndexModel() { 
                TopCouples = db.Couple.OrderBy(c => c.VouteCount).Take(5), 
                Posts= db.PostBlog.Take(6)};
            return View(model);
        }

    }
}
