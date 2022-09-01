using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Udemy_ASP.NET_MVC5_Vidly.Models;

namespace Udemy_ASP.NET_MVC5_Vidly.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customer { get; set; }


    }
}