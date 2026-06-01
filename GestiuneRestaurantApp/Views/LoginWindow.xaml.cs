using System.Windows;
using GestiuneRestaurantApp.Models;
using GestiuneRestaurantApp.Services;
using GestiuneRestaurantApp.ViewModels;

namespace GestiuneRestaurantApp.Views
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();

            LoginViewModel viewModel = new LoginViewModel(new AuthService());

            viewModel.LoginSuccessful += OpenMainWindow;
            
            DataContext = viewModel;
        }

        private void OpenMainWindow(User user)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Title = $"Gestiune Restaurant - {user.Nume} ({user.Rol})";
            mainWindow.Show();

            Close();
        }
    }
}
