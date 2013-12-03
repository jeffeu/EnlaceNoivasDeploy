using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EnlaceNoivas.Models;
using EnlaceNoivas.ViewModels;

namespace EnlaceNoivas.Controllers
{
    public class EmailController : Controller
    {
        //
        // GET: /Email/
        private db db = new db(); 
        public ActionResult Register(IndexModel indexModel)
        {
            EmailList el = indexModel.EmailList;

            if (ModelState.IsValid)
            {
                db.EmailList.Add(indexModel.EmailList);
                db.SaveChanges();
            }
            
            return RedirectToAction("Index","Home");
        }

    }
}
