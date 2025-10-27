using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Wasalni_Models;

namespace Wasalni_DataAccess.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Bus> Buses { get; set; }
        public DbSet<BusTrip> BusTrips { get; set; }
        public DbSet<RoutePlan> RoutePlans { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<TripPoint> TripPoints { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<DriverProfile> DriverProfiles { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<RideRequest> RideRequests { get; set; }

        public AppDbContext(DbContextOptions Options) : base(Options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Bus>().HasKey(x => x.Id);
            builder.Entity<Bus>().Property(x => x.PlateNumber).HasMaxLength(7).IsRequired(true);
            builder.Entity<Bus>().Property(x => x.Capacity).IsRequired(true);
            builder.Entity<Bus>().HasOne(x => x.DiverProfile).WithOne(x => x.Bus).HasForeignKey<DriverProfile>(x => x.BusId);
            builder.Entity<Passenger>()
    .HasOne(p => p.FromLocation)
    .WithMany()
    .HasForeignKey(p => p.FromLocationId)
    .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Passenger>()
                .HasOne(p => p.ToLocation)
                .WithMany()
                .HasForeignKey(p => p.ToLocationId)
                .OnDelete(DeleteBehavior.NoAction);



        }
    }
}
