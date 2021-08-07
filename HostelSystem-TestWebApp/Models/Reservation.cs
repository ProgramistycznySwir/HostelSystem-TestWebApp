using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HostelSystem_TestWebApp.Models
{
    public class Reservation
    {
        //- Kod Rezerwacji(max 10 znaków),
        public string Code { get; set; }
        //- Daty utworzenia,
        public DateTime CreationDate { get; set; }
        //- Cena,
        public int Price { get; set; }
        //- Data zameldowania,
        public DateTime CheckInDate { get; set; }
        //- Data wymeldowania,
        public DateTime CheckOutDate { get; set; }
        //- Waluta,
        public string CurrencyCode { get; set; }
        //- Id.
        // Nie ma potrzeby komplikować bazy przy pomocy long'a i BIGINT'a, więc tutaj wstawiam zwykłego int'a
        public int ID { get; set; }

        //- Prowizja,
        public int Provision { get; set; }
        //- Źródło.
        public string Source { get; set; }
    }
}