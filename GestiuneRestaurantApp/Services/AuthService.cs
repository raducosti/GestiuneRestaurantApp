using GestiuneRestaurantApp.Data;
using GestiuneRestaurantApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GestiuneRestaurantApp.Services
{
    public class AuthService : IAuthService
    {
        private readonly RestaurantDbContext _context;

        public AuthService()
        {
            _context = new RestaurantDbContext();
        }

        public async Task<User?> LoginAsync(string pin)
        {
            return await _context.Users
                .FirstOrDefaultAsync(user => user.Pin == pin);

        }
    }
}
