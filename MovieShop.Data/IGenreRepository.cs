using MovieShop.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieShop.Data
{
    public interface IGenreRepository : IRepository<Genre>
    {
        Task<IEnumerable<Movie>> GetMoviesByGenre(int genreid);
    }
}
