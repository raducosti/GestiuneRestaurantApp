namespace GestiuneRestaurantApp.Models
{
    public class Comanda
    {
        public int Id { get; set; }

        public DateTime DataOra { get; set; } = DateTime.Now;

        public string Status { get; set; } = "Activa";

        public int MasaId { get; set; }

        public Masa? Masa { get; set; }
    }
}
