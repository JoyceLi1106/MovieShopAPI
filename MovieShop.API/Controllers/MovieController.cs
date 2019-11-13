using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieShop.Services;

namespace MovieShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;
        public MovieController(IMovieService movieService)
        {
            _movieService = movieService; 
        }

        [HttpGet]
        [Route("topgrossing")]
        public async Task<IActionResult> GetTopGrossingMovies()
        {
            var movies = await _movieService.GetHighestGrossingMovies();
            return Ok(movies);
        }

        


    }
}