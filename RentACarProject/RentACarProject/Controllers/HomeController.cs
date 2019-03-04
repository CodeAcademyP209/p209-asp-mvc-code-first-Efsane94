using RentACarProject.DAL;
using RentACarProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentACarProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly CarContext _context;
        public HomeController()
        {
            _context = new CarContext();
        }
        public ActionResult Index()
        {
            return View(_context.Cars);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Car car)
        {
            if (!ModelState.IsValid)
            {
                return View(car);
            }
            _context.Cars.Add(car);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}