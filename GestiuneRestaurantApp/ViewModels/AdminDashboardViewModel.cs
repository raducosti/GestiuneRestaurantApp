using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace GestiuneRestaurantApp.ViewModels
{
    public partial class AdminDashboardViewModel : ObservableObject
    {
        private readonly Action _showMese;
        public string Title => "Administrare";

        public AdminDashboardViewModel(Action showMese)
        {
            _showMese = showMese;
        }

        [RelayCommand]
        private void ShowMese()
        {
            _showMese.Invoke();
        }
    }
}
