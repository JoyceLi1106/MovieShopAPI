using MovieShop.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;

namespace MovieShop.Data
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(MovieShopDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<User> GetUserByEmail(string email)
        {
            return await _dbContext.users.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<IEnumerable<Purchase>> GetUserPurchaseMovies(int userid)
        {
            var userMovies = await _dbContext.purchases.Where(p => p.UserId == userid).Include(p => p.Movie).ToListAsync();
            return userMovies;       
        }
        

        }
    }

