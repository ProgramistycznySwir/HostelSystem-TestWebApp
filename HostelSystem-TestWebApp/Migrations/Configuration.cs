namespace HostelSystem_TestWebApp.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HostelSystem_TestWebApp.Models.ReservationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HostelSystem_TestWebApp.Models.ReservationContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            
            List<Guest> newGuests = new List<Guest>();
            List<Reservation> newReservations = new List<Reservation>();
            
            newReservations.Add(Bogus.Reservation);
            newReservations.Add(Bogus.Reservation);
            newReservations.Add(Bogus.Reservation);
            newGuests.Add(Bogus.Guest);
            newGuests.Add(Bogus.Guest);
            newGuests.Add(Bogus.Guest);
            newGuests.Add(Bogus.Guest);
            newGuests.Add(Bogus.Guest);

            foreach (var guest in newGuests)
                guest.Reservations = new List<Reservation>();

            // Z tego nie jestem wybitnie dumny, ale musi wystarczyæ:
            // Przez chwilê myœla³em, ¿e nie uda mi siê wype³niæ list w taki sposób, ale okaza³o siê, ¿e to kontroler 
            //  jest Ÿle napisany, nie to co tutaj odczyni³em :D
            newReservations[0].Guests = new List<Guest>() { newGuests[0], newGuests[1] };
            newGuests[0].Reservations.Add(newReservations[0]);
            newGuests[1].Reservations.Add(newReservations[0]);
            newReservations[1].Guests = new List<Guest>() { newGuests[1], newGuests[2], newGuests[3] };
            newGuests[1].Reservations.Add(newReservations[1]);
            newGuests[2].Reservations.Add(newReservations[1]);
            newGuests[3].Reservations.Add(newReservations[1]);
            newReservations[2].Guests = new List<Guest>() { newGuests[4] };
            newGuests[4].Reservations.Add(newReservations[2]);

            context.Reservations.AddOrUpdate(newReservations.ToArray());
            context.Guests.AddOrUpdate(newGuests.ToArray());
        }
    }
}
