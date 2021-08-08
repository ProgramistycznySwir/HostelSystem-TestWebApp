using HostelSystem_TestWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HostelSystem_TestWebApp
{
    public static class Bogus
    {
        public static Random rng = new Random();

        // Pewnie jest jakaś biblioteka od tego, ale, łatwiej jest skopiować kod z stack'a :D
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        public static string String(int length)
            => new string(Enumerable.Repeat(chars, length)
                  .Select(s => s[rng.Next(s.Length)]).ToArray());

        public static Reservation Reservation => new Reservation {
            Code = Bogus.String(8),
            CreationDate = new DateTime(rng.Next(2015, 2020), rng.Next(1, 12), rng.Next(1,12)),
            Price = rng.Next(2000, 200000),
            CheckInDate = new DateTime(rng.Next(2015, 2020), rng.Next(1, 12), rng.Next(1, 12)),
            CheckOutDate = new DateTime(rng.Next(2015, 2020), rng.Next(1, 12), rng.Next(1, 12)),
            CurrencyCode = new string[]{ "PLN", "EUR", "USD" }[rng.Next(3)],
            //ID,

            Provision = rng.Next(0, 20000),
            Source = new string[]{ null, "Facebook", "Google" }[rng.Next(3)]
        };

        // TODO: Można generować imiona itp. przy pomocy pakietu Bogus.
        public static Guest Guest => new Guest
        {
            Name = new string[]{ "Bob", "Sara", "Tom", "Jack", "Anna", "Piotr" }[rng.Next(5)],
            Surname = new string[] { "Abrams", "Bardock", "Cabbage", "Dandelion", "Evergreen" }[rng.Next(5)],
            Email = Bogus.String(24),
            //ID,

            BirthDate = new DateTime(rng.Next(1970, 2000), rng.Next(1, 12), rng.Next(1, 12)),
            PostalCode = Bogus.String(32),

            PhoneNumber = rng.Next(3) == 0 ? rng.Next(100000000, 999999999).ToString() : null,
            //Address = null,
            City = new string[] { null, "Wrocław", "Warszawa", "Białystok" }[rng.Next(4)]
        };
    }
}