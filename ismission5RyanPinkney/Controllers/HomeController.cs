// Author Ryan Pinkney
// This is the home controller to direct all the route traffic on our site.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ismission5RyanPinkney.Models;
using Microsoft.EntityFrameworkCore;

namespace ismission5RyanPinkney.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        // Database configurations
        private MovieContext DaContext { get; set; }


        // Database configurations
        public HomeController(ILogger<HomeController> logger, MovieContext someName)
        {
            _logger = logger;
            DaContext = someName;
        }

        // Route for the index
        public IActionResult Index()
        {
            return View();
        }

        // Route for the privacy
        public IActionResult Privacy()
        {
            return View();
        }

        // Route for the Podcast
        public IActionResult Podcast()
        {
            return View();
        }

        // Route for the get Movie
        [HttpGet]
        public IActionResult Movie()
        {

            // Fill the bag
            ViewBag.lstCategories = DaContext.categories.ToList();

            return View();
        }

        // Route for the post Movie
        [HttpPost]
        public IActionResult Movie(Movie response)
        {
            // Check to see if the data inputed is valid
            if (!ModelState.IsValid)
            {
                // Load the bag
                ViewBag.lstCategories = DaContext.categories.ToList();


                return View(response);
            }

            // Save the infomration to the database
            DaContext.Add(response);

            // Save changes on the database
            DaContext.SaveChanges();


            // Return them to the confirmation page
            return View("com", response);
        }


        // Get route to the movie list
        [HttpGet]
        public IActionResult MovieList()
        {
            // Pull a list of all movies from the database using tolist()
            var lstDataList = DaContext.responses
                .Include(x => x.Category)
                .ToList();


            // Return a view with the list of objects
            return View(lstDataList);
        }

        // Route to edit get
        [HttpGet]
        public IActionResult Edit(int id)
        {
            // Set the page
            ViewBag.lstCategories = DaContext.categories.ToList();


            // Pull a single record
            var oSingleRecord = DaContext.responses
            .Single(x => x.movie_id == id);


            // Return the view with the single object
            return View(oSingleRecord);
        }

        // Route to edit post
        [HttpPost]
        public IActionResult Edit(Movie response)
        {

            // Check to see if the data inputted was valid
            if (!ModelState.IsValid)
            {

                // Load the bag
                ViewBag.lstCategories = DaContext.categories.ToList();

                // Return to waitlist
                return View(response);


            };


            // Save the infomration to the database
            DaContext.Update(response);

            // Save changes on the database
            DaContext.SaveChanges();

            // Redirect to the movie list route
            return RedirectToAction("MovieList");
        }

        // Route to Delete get
        [HttpGet]
        public IActionResult Delete(int id)
        {

            // Pull a single record
            var oSingleRecord = DaContext.responses
            .Single(x => x.movie_id == id);


            // Return the view with the single object
            return View(oSingleRecord);
        }

        // Route to delete post
        [HttpPost]
        public IActionResult Delete(Movie response)
        {
            // Delete the record identifed by the id in the response
            DaContext.responses.Remove(response);

            // Save changes on the database
            DaContext.SaveChanges();

            // Redirect to the movie list route
            return RedirectToAction("MovieList");
        }



        // Default code created by VS code
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
