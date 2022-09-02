using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Udemy_ASP.NET_MVC5_Vidly.Models;
using Udemy_ASP.NET_MVC5_Vidly.ViewModels;

namespace Udemy_ASP.NET_MVC5_Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customer
        public ActionResult Customers()
        {
            var customers = new List<Customer> {
                new Customer { Name = "James" },
                new Customer { Name = "Geoffrey" }
            };

            var viewModel = new CustomersViewModel()
            {
                Customer = customers
            };
                
            return View(viewModel);
        }
    }
}