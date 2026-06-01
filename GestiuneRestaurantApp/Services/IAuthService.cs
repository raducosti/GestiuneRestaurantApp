using GestiuneRestaurantApp.Models;


namespace GestiuneRestaurantApp.Services
{
    public interface IAuthService
    {
        Task<User?> LoginAsync(string pin);
    }
}
