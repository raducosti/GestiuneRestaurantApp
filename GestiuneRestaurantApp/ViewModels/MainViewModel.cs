using CommunityToolkit.Mvvm.ComponentModel;
using GestiuneRestaurantApp.Models;
using GestiuneRestaurantApp.Services;

namespace GestiuneRestaurantApp.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        public User CurrentUser { get; }
        public string UserName => CurrentUser.Nume;
        public string UserRole => CurrentUser.Rol;
        public bool IsAdmin => CurrentUser.Rol == "Admin";
        public bool IsWaiter => CurrentUser.Rol == "Ospatar";

        [ObservableProperty]
        private object? currentViewModel;
        public MainViewModel(User user)
        {
            CurrentUser = user;
            if(IsAdmin)
            {
                CurrentViewModel = new AdminDashboardViewModel(ShowMese);
            }
            else
            {
                ShowMese();
            }
        }

        private void ShowMese()
        {
            CurrentViewModel = new MeseViewModel(new MasaService(), ShowComanda);
        }

        private void ShowComanda(Masa masa)
        {
            CurrentViewModel = new ComandaViewModel(masa, new ProdusService());
        }

    }
}
