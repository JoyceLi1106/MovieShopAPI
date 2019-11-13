using System;
using System.Collections.Generic;
using System.Text;

namespace MovieShop.Services
{
    public interface ICryptoService
    {
        string CreateSalt();
        string HashPassword(string password, string salt);
    }
}
