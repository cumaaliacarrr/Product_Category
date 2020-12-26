using Product_Cagetory.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Product_Cagetory.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context = new DataContext();


        // GET: Home
        public ActionResult Index()
        {
            return View(_context.Products.Where(p=>p.IsHome==true && p.IsApproved==true).ToList());
        }
        public ActionResult Details(int id)
        {
            return View(_context.Products.Where(p=>p.Id==id).FirstOrDefault());
        }
        public ActionResult List()
        {
            return View(_context.Products.Where(p =>  p.IsApproved == true).ToList());
        }
    }
}