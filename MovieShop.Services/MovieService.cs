using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MovieShop.Entities;
using MovieShop.Data;

namespace MovieShop.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
    
        public async Task<IEnumerable<Movie>> GetHighestGrossingMovies()
        {
            return await _movieRepository.GetHighestGrossingMovies();
        }
    
    }
}
