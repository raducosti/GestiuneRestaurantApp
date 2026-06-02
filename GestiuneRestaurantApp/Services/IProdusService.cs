using GestiuneRestaurantApp.Models;

namespace GestiuneRestaurantApp.Services
{
    public interface IProdusService
    {
        Task<List<Produs>> GetProduseAsync();
    }
}
