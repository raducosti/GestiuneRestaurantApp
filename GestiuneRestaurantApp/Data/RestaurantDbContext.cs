using Microsoft.EntityFrameworkCore;
using GestiuneRestaurantApp.Models;

namespace GestiuneRestaurantApp.Data
{
    public class  RestaurantDbContext : DbContext
    {
        public DbSet<Masa> Mese { get; set; }
        public DbSet<CategorieProdus> CategoriiProduse { get; set; }
        public DbSet<Produs> Produse { get; set; }
        public DbSet<Comanda> Comenzi { get; set; }
        public DbSet<DetaliiComanda> DetaliiComenzi { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=RestaurantDb;Trusted_Connection=True;");
            }
        }
    }
}
