using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MovieShop.Data;
using MovieShop.Entities;

namespace MovieShop.Services
{
    public class UserService : IUserService
    {
        private readonly ICryptoService _cryptoService;
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository, ICryptoService cryptoService)
        {
            _userRepository = userRepository;
            _cryptoService = cryptoService;
        }
        
        public async Task<User> CreateUser(string email, string password, string firstName, string lastName)
        {
            var dbUser = await _userRepository.GetUserByEmail(email);
            if (dbUser != null)
            {
                return null;
            }
            var salt = _cryptoService.CreateSalt();
            var hashPassword = _cryptoService.HashPassword(password, salt);
            var user = new User { 
                Email = email, 
                FirstName = firstName, 
                LastName = lastName,
                HashedPassword = hashPassword,
                Salt = salt
            };
            var CreatedUser = await _userRepository.AddAsync(user);
            return CreatedUser;
        }

        public async Task<IEnumerable<Purchase>> GetPurchases(int userid)
        {
            return await _userRepository.GetUserPurchaseMovies(userid);
        }

        public async Task<User> ValidateUser(string email, string password)
        {
            var dbUser = await _userRepository.GetUserByEmail(email);
            if (dbUser == null)
            {
                return null; 
            }
            var salt = dbUser.Salt;
            var hashedPassword = dbUser.HashedPassword;
            var validatedPassword = _cryptoService.HashPassword(password, salt);
            if (validatedPassword != hashedPassword)
            {
                return null;
            }
            return dbUser;
        }
    }
        
    }

