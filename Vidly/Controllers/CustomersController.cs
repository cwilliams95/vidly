using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [Route("Customers/Details/{id}")]
        public ActionResult Details(int id)
        {
            var customers = _context.Customers.SingleOrDefault(cust => cust.Id == id);

            if (customers == null)
                return HttpNotFound();

            return View(customers);

        }

        public ViewResult Index(int? pageIndex, string sortBy)
        {
            var customers = _context.Customers.ToList();
            return View(customers);
        }

    }
}