using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HostelSystem_TestWebApp.Models
{
    public class Reservation
    {
        //- Kod Rezerwacji(max 10 znaków),
        [Required]
        public string Code { get; set; }
        //- Daty utworzenia,
        [Required]
        public DateTime CreationDate { get; set; }
        //- Cena,
        [Required]
        public int Price { get; set; }
        //- Data zameldowania,
        [Required]
        public DateTime CheckInDate { get; set; }
        //- Data wymeldowania,
        [Required]
        public DateTime CheckOutDate { get; set; }
        //- Waluta,
        [Required]
        public string CurrencyCode { get; set; }
        //- Id.
        // Nie ma potrzeby komplikować bazy przy pomocy long'a i BIGINT'a, więc tutaj wstawiam zwykłego int'a
        [Required]
        public int ID { get; set; }

        //- Prowizja,
        public int Provision { get; set; }
        //- Źródło.
        public string Source { get; set; }

        public ICollection<Guest> Guests { get; set; }
    }
}