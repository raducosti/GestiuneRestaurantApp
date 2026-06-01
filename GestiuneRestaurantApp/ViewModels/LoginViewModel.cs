using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GestiuneRestaurantApp.Models;
using GestiuneRestaurantApp.Services;

namespace GestiuneRestaurantApp.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        private readonly IAuthService _authService;

        [ObservableProperty]
        private string pin = string.Empty;

        [ObservableProperty]
        private string errorMessage = string.Empty;

        public event Action<User>? LoginSuccessful;

        public LoginViewModel(IAuthService authService)
        {
            _authService = authService;
        }

        [RelayCommand]
        private void AddDigit(string digit)
        {
            Pin += digit;
            ErrorMessage = string.Empty;
        }

        [RelayCommand]
        private void ClearPin()
        {
            Pin = string.Empty;
            ErrorMessage = string.Empty;
        }

        [RelayCommand]
        private async Task Login()
        {
            if (string.IsNullOrEmpty(Pin))
            {
                ErrorMessage = "Introdu PIN-ul.";
                return;
            }

            User? user = await _authService.LoginAsync(Pin);

            if(user == null)
            {
                ErrorMessage = "PIN incorect.";
                Pin = string.Empty;
                return;
            }
            ErrorMessage = string.Empty;
            LoginSuccessful?.Invoke(user);
        }
    }
}
