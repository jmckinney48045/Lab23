using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab23.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lab23.Controllers
{

    public class SearchController : Controller
    {
        private SearchResult _listOfMovies;

        public SearchController()
        {
            _listOfMovies = new SearchResult
            {
                MovieList = new List<Movie>()
                {
                new Movie("What Lies Beneath", MovieGenre.Horror),
                new Movie("Scary Movie", MovieGenre.Horror),
                new Movie("It", MovieGenre.Horror),
                new Movie("Poltergeist", MovieGenre.Horror),
                new Movie("Last Action Hero", MovieGenre.Action),
                new Movie("Avengers: Infinity War", MovieGenre.Action),
                new Movie("Mission Impossible", MovieGenre.Action),
                new Movie("Terminator", MovieGenre.Action),
                new Movie("Nutty Professor", MovieGenre.Comedy),
                new Movie("Elf", MovieGenre.Comedy),
                new Movie("Step Brothers", MovieGenre.Comedy),
                new Movie("Dumb and Dumber", MovieGenre.Comedy),
                new Movie("A Star is Born", MovieGenre.Drama),
                new Movie("Schindler's List", MovieGenre.Drama),
                new Movie("Joker", MovieGenre.Drama),
            
            }
            };

            _listOfMovies.MovieList = _listOfMovies.MovieList.OrderBy(x => x.Title).ToList();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SearchResultTitle(string title)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            _listOfMovies.SearchTitle(title);

            return View(_listOfMovies);
        }

        [HttpPost]
        public IActionResult SearchResultGenre(string genre)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            _listOfMovies.SearchGenre(genre);

            return View(_listOfMovies);
        }

    }
}