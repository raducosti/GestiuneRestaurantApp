namespace GestiuneRestaurantApp.Models
{
    public class DetaliiComanda
    {
        public int Id { get; set; }

        public int Cantitate { get; set; } = 0;

        public decimal PretIstoric { get; set; }

        public int ComandaId { get; set; }
        public Comanda? Comanda { get; set; }

        public int ProdusId { get; set; }
        public Produs? Produs { get; set; }
    }
}
