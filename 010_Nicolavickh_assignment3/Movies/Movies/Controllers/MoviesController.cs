using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Movies.Controllers;
using Movies.Models;

namespace Movies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private MoviesContext _context;
        public MoviesController(MoviesContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<MoviesItem>> GetAllMoviesItems()
        {
            _context = HttpContext.RequestServices.GetService(typeof(MoviesContext)) as MoviesContext;
            return _context.GetAllMovies();
        }

        [HttpGet("{id}")]
        public ActionResult<IEnumerable<MoviesItem>> GetMoviesItemById(String id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MoviesContext)) as MoviesContext;
            return _context.GetMoviesById(id);
        }

        [HttpPost]
        public string AddMovies(MoviesItem movie) {
            _context = HttpContext.RequestServices.GetService(typeof(MoviesContext)) as MoviesContext;
            return _context.AddMovie(movie);
        }

        [HttpPut("{id}")]
        public string UpdateMovie(int id, MoviesItem movie)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MoviesContext)) as MoviesContext;
            return _context.UpdateMovie(id, movie);
        }

        [HttpDelete("{id}")]
        public string DeletMovie(int id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MoviesContext)) as MoviesContext;
            return _context.DeletMovie(id);
        }
    }
}
