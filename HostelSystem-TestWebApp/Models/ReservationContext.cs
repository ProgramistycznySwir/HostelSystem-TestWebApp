using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HostelSystem_TestWebApp.Models
{
    public class ReservationContext : DbContext
    {
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Guest> Guests { get; set; }

        public ReservationContext()
            : base(
                nameOrConnectionString: "name=HostelDB"
            )
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation>()
                .HasMany(a => a.Guests);
            modelBuilder.Entity<Guest>()
                .HasMany(a => a.Reservations);
        }
    }
}