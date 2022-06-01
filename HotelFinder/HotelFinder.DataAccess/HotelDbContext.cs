using HotelFinder.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelFinder.DataAccess
{
    public class HotelDbContext : DbContext
    {
        //ilk yapacağımız şey configure metodunu override etmek
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            // sornasında bcontext yazıyoruz bağlantı cümlesi
            optionsBuilder.UseSqlServer(@"Server=IDEA-PC\SQLEXPRESS01;Database=Hotells;Trusted_Connection=True");
        }
        //sonrasında veri modelimizden sqlde tablo oluşturuyoruz
        public DbSet<Hotel> Hotels { get; set; }
        //yukarıdaki kod Hotl sınıfından veri tabanına Hotels adında tablo oluşturur

    }
}
