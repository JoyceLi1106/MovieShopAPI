using MovieShop.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieShop.Services
{
    public interface IUserService
    {
        Task<User> ValidateUser(string email, string password);
        Task<User> CreateUser(string email, string password, string firstName, string lastName);
        Task<IEnumerable<Purchase>> GetPurchases(int userid); 
    }
}
