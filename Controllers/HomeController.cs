using Google.Apis.Admin.Directory.directory_v1.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApplication.Controllers
{
    public class HomeController : Controller
    {

        WebDBContext db = new WebDBContext();

        public IActionResult Index()
        {
           
            return View();
        }

        public IActionResult Submit(TblUserDetail tblUserDetail)
        {
            db.TblUserDetails.Add(tblUserDetail);
            db.SaveChanges();
           return RedirectToAction("Index");
        }

        public IActionResult List()
        {
            var list = db.TblUserDetails;
            return View(list);
        }

        
    }
}
