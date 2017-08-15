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
        [Route("customers/{id}")]
        public ActionResult CustomersById(int id)
        {
            return View();
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            var customers = new List<Customer>
            {
                new Models.Customer { Name = "Mary Price"},
                new Models.Customer { Name = "Joe Schmo" }
            };
            var viewModel = new CustomerViewModel
            {
                Customers = customers
            };
            return View(viewModel);
        }
    }
}