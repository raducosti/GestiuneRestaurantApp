using System.Windows;
using GestiuneRestaurantApp.Models;
using GestiuneRestaurantApp.ViewModels;

namespace GestiuneRestaurantApp.Views
{

    public partial class MainWindow : Window
    {
        public MainWindow(User user)
        {
            InitializeComponent();

            DataContext = new MainViewModel(user);
        }
    }
}