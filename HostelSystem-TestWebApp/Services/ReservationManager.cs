using HostelSystem_TestWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HostelSystem_TestWebApp.Services
{
    // For now it's pseudo service since I've decided to do more important stuff not fight with old SDK.
    public static class ReservationManager
    {
        static ReservationContext db = new ReservationContext();

        // "metoda zrzucająca wszystkie rezerwacje (bez parametru)"
        public static IQueryable<Reservation> GetAllReservations()
        {
            return db.Reservations;
        }

        // "metoda zrzucająca listę wszystkich gości o imieniu Piotr z miasta Wrocław lub bez miasta"
        public static IQueryable<Guest> GetPetersFromWrocławOrNot()
        {
            return from guest in db.Guests
                   where guest.Name == "Piotr" 
                        && new string[] { null, "Wrocław" }.Contains(guest.City)
                    select guest;
        }

        // "metodą zapisująca rezerwację wraz z gośćmi na podstawie przekazanych parametrów"
        public static void AddReservation(Reservation reservation)
        {
            db.Reservations.Add(reservation);
            db.SaveChanges();
        }
    }
}