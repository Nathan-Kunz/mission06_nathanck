using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mission06_nathanck.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace mission06_nathanck.Controllers
{
    public class HomeController : Controller
    {
        
        private MovieReviewContext blahcontext { get; set; }

        public HomeController( MovieReviewContext someName)
        {
            
            blahcontext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

           

        [HttpGet]
        public IActionResult form()
        {
            ViewBag.Movies = blahcontext.Movies.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult form(ApplicationResponse ar)
        {
          
            
                blahcontext.Add(ar);
                blahcontext.SaveChanges();
                return View("Index");
            
          
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Movies = blahcontext.Movies.ToList();

            var movie = blahcontext.responses.Single(x => x.MovieId==id);
            return View("form", movie);
        }

        [HttpPost]
        public IActionResult Edit(ApplicationResponse blah)
        {
            blahcontext.Update(blah);
            blahcontext.SaveChanges();
            return RedirectToAction("movies");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var movie = blahcontext.responses.Single(x => x.MovieId == id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {
            blahcontext.responses.Remove(ar);
            blahcontext.SaveChanges();
            return RedirectToAction("movies");
        }

      
        public IActionResult movies()
        {
            var mList = blahcontext.responses
                .Include(x => x.MovieCategory)
                .ToList();
            return View(mList);
        }
        
    }
}
