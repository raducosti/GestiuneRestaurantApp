using GestiuneRestaurantApp.Models;

namespace GestiuneRestaurantApp.Services
{
    public interface IMasaService
    {
        Task<List<Masa>> GetMeseAsync();
    }
}
