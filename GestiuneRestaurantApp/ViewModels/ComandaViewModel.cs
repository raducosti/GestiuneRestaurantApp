using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GestiuneRestaurantApp.Models;
using GestiuneRestaurantApp.Services;

namespace GestiuneRestaurantApp.ViewModels
{
    public partial class ComandaViewModel: ObservableObject
    {
        private readonly IProdusService _produsService;

        public Masa MasaSelectata { get; }

        [ObservableProperty]
        private ObservableCollection<Produs> produse = new();

        [ObservableProperty]
        private string errorMessage = string.Empty;

        public string Titlu => $"Comanda - Masa {MasaSelectata.Numar}";

        public ComandaViewModel(Masa masa, IProdusService produsService)
        {
            MasaSelectata = masa;
            _produsService = produsService;

            _ = LoadProduse();
        }

        [RelayCommand]
        public async Task LoadProduse()
        {
            try
            {
                List<Produs> listaProduse = await _produsService.GetProduseAsync();
                Produse = new ObservableCollection<Produs>(listaProduse);
                ErrorMessage = string.Empty;
            }
            catch
            {
                ErrorMessage = "Eroare la incarcarea produselor.";
            }
        }

        [RelayCommand]
        private void AddProdus(Produs produs)
        {
            if(produs == null)
            {
                return;
            }
        }
    }
}
