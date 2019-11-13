using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieShop.Entities;
using MovieShop.Services;

namespace MovieShop.API.Controllers
{
    [Route("api/[controller]")] //api/genre 
    [ApiController] //attribute routing 
    public class GenreController : ControllerBase
    {
        private readonly IGenreService _genreService;
        public GenreController(IGenreService genreService)
        {
            _genreService = genreService;
        }
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllGenres()
        {
            var genres = await _genreService.GetAllGenres();
            if (genres.Any()) //boolean value => if it is true
            {
                return Ok(genres);
            }
            return NotFound();
        }

        [HttpGet]
        [Route("{id}/movies")]
        public async Task<IActionResult> GetMoviesByGenre(int id)
        {
            var movies =await _genreService.GetMoviesByGenre(id);
            return Ok(movies);
        }

  
    }
}