using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Udemy_ASP.NET_MVC5_Vidly.Models;
using Udemy_ASP.NET_MVC5_Vidly.ViewModels;

namespace Udemy_ASP.NET_MVC5_Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer> {
                new Customer { Name = "James" },
                new Customer { Name = "Geoffrey" }
            };

            var viewModel = new CustomersViewModel()
            {
                Movie = movie,
                Customer = customers
            };

            return View(viewModel);
        }



       /* [Route("movies/released/{year}/{month:regex(\\d{4})}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }*/
    }
} 