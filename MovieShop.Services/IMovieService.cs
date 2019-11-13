using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MovieShop.Entities;

namespace MovieShop.Services
{
    public interface IMovieService
    {
        Task<IEnumerable<Movie>> GetHighestGrossingMovies();
    }
}
