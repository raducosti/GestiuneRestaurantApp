using GestiuneRestaurantApp.Data;
using GestiuneRestaurantApp.Models;
using Microsoft.EntityFrameworkCore;


namespace GestiuneRestaurantApp.Services
{
    public class MasaService : IMasaService
    {
        private readonly RestaurantDbContext _context;

        public MasaService()
        {
            _context = new RestaurantDbContext();
        }

        public async Task<List<Masa>> GetMeseAsync()
        {
            return await _context.Mese
                .OrderBy(masa => masa.Numar)
                .ToListAsync();
        }
    }
}
