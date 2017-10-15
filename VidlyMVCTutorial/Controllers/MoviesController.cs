using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyMVCTutorial.Models;
using VidlyMVCTutorial.ViewModel;

namespace VidlyMVCTutorial.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            Movie movie1 = new Movie() { Name = "Shrek" };

            var customers = new List<Customer>  //uh oh he used var
            {
                new Models.Customer {name = "Customer One" },
                new Customer {name = "Customer Two" }
            };


            //here are some examples of what could be returned:
            //return View(movie1);
            //return Content("Hello World!");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new {page = 1, sortBy = "name" });

            return View(movie1);
        }

        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1, 12)}")] 
        //this is an attribute route
        //we created it
        //google "attribute route constraints" for more info.

        public ActionResult Edit(int ID)
        {
            return Content("id=" + ID);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format($"pageIndex={pageIndex}&sortBy={sortBy}"));
        }

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}