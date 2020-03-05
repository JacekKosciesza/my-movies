using Microsoft.AspNetCore.Mvc;
using MyMovies.Models;
using System.Collections.Generic;

namespace MyMovies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            var movies = new List<Movie>
            {
                new Movie
                {
                    Id = 1,
                    Title = "Green Book"
                },
                new Movie
                {
                    Id = 2,
                    Title = "Parasite"
                }
            };

            return movies;
        }
    }
}