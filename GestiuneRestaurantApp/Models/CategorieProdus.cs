namespace GestiuneRestaurantApp.Models
{
    public class CategorieProdus
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string DestinatiePrint { get; set; } = string.Empty; //pentru services
    }
    
}