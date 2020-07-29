using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab23.Controllers
{
    public class MoviesController : Controller
    {
        private readonly movies_dbContext _context;

        public MoviesController(movies_dbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        { //this accesses database and putting into list
            return View(_context.Movies.ToList());
        }

       public IActionResult Create()
        {
            return View();
        }
        public IActionResult Create(Movies movie)
        {
           
                _context.Add(movie);
                _context.SaveChangegs();
          
            return View();
        }        
    }
}