using Microsoft.EntityFrameworkCore;

namespace HotelContext.Data
{
    public class HotelContext : DbContext {

        public HotelContext(DbContextOptions<HotelContext> options) : base(options){

        } 
        
        public DbSet<Guest> Guests {get; set;}
        public DbSet<Reservation> Reservations {get; set;}

        protected override void OModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Guest>()
           .HasMany(s => s.Reservations)
           .WithOne(a => a.Guest)
           .HasForeignKey(a => a.GuestId);
        }

    }

}