using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "The Big Lebowski" };  //This is another way to pass the movie to the view. Name is a property of the Movie class

            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }

            };

            var ViewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
           

            return View(ViewModel); 
                                

        }







        // GET: Movies/Random
        //public ActionResult Random()
        //{
        //    var movie = new Movie() { Name = "The Big Lebowski" };

        //    //return Content("Hello World!");       Plain String Content
        //    //return View(movie);                   Movie View
        //    //return HttpNotFound();                  404 Error
        //    //return new EmptyResult();
        //    return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });       //Parameters or Arguments are Action, Controller, 
        //}


        //public ActionResult Edit(int id)            //New action with parameter of an id
        //{
        //    return Content("id=" + id);
        //}


        ////Next action will be called when we navigate to movies
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;

        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";

        //    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}


        //[Route("movies/released/{year}/{month: regex(\\d{4}):range(1, 12)}")]
        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year + "/" + month );
        //}

    }
}