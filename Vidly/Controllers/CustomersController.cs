using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController:Controller
    {
        [Route("Customers/Details/{id}")]
        public ActionResult Details(int id)
        {
            var customers = new List<Customer>
            {
                new Models.Customer { Name = "Mary Price", Id = 1},
                new Models.Customer { Name = "Joe Schmo", Id = 2}
            };
            
            var selected = customers.Where(cust => cust.Id == id);
            if (selected.Count() > 0)
                return View(selected.ElementAt(0));
            else
                return HttpNotFound();
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            var customers = new List<Customer>
            {
                new Models.Customer { Name = "Mary Price", Id = 1},
                new Models.Customer { Name = "Joe Schmo", Id = 2}
            };
            var viewModel = new CustomerViewModel
            {
                Customers = customers
            };
            return View(viewModel);
        }
    }
}