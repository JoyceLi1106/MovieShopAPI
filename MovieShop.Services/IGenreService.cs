using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MovieShop.Entities;
using MovieShop.Data;


namespace MovieShop.Services
{
    public interface IGenreService
    {
        Task<IEnumerable<Genre>> GetAllGenres();
        Task<IEnumerable<Movie>> GetMoviesByGenre(int genreid);
    }
}
