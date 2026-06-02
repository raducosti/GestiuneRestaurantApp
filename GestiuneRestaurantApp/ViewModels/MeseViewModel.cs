using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GestiuneRestaurantApp.Models;
using GestiuneRestaurantApp.Services;


namespace GestiuneRestaurantApp.ViewModels
{
    public partial class MeseViewModel : ObservableObject
    {
        private readonly IMasaService _masaService;
        private readonly Action<Masa> _showComanda;

        [ObservableProperty]
        private ObservableCollection<Masa> mese = new();

        [ObservableProperty]
        private string errorMessage = string.Empty;

        public MeseViewModel(IMasaService masaService, Action<Masa> showComanda)
        {
            _masaService = masaService;
            _showComanda= showComanda;

            _ = LoadMese();
        }

        [RelayCommand]
        public async Task LoadMese()
        {
            try
            {
                List<Masa> listaMese = await _masaService.GetMeseAsync();
                Mese= new ObservableCollection<Masa>(listaMese);

                ErrorMessage = string.Empty;
            }
            catch
            {
                ErrorMessage = "Nu se pot incarca mesele.";
            }
        }

        [RelayCommand]
        private void SelectMasa(Masa masa)
        {
            if(masa==null)
            {
                return;
            }

            _showComanda.Invoke(masa);
        }

    }
}
