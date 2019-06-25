using FoodNStuff.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodNStuff.MVC.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();
        // GET: Customer
        public ActionResult Index()
        {
            return View(_db.Customers.ToList());
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        //POST: Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
        {
            if (ModelState.IsValid) // Check if data is valid
            {
                _db.Customers.Add(customer); // Add
                _db.SaveChanges(); // Save changes to DB
                return RedirectToAction("Index"); // Return to home
            }

            return View(customer); // If not valid, return to same page
        }


    }
}