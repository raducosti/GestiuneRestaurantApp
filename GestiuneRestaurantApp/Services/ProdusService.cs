using GestiuneRestaurantApp.Data;
using GestiuneRestaurantApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GestiuneRestaurantApp.Services
{
    public class ProdusService : IProdusService
    {
        private readonly RestaurantDbContext _context;

        public ProdusService()
        {
            _context = new RestaurantDbContext();
        }

        public async Task<List<Produs>> GetProduseAsync()
        {
            return await _context.Produse
                .Include(produs => produs.Categorie)
                .OrderBy(produs => produs.Nume)
                .ToListAsync();
        }
    }
}
