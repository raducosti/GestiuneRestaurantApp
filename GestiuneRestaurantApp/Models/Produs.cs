namespace GestiuneRestaurantApp.Models
{
    public class Produs
    {
        public int Id { get; set; }

        public string Nume { get; set; } = string.Empty;

        public decimal Pret { get; set; } 

        public int CategorieProdusId { get; set; }

        public CategorieProdus? Categorie {  get; set; }
    }
}