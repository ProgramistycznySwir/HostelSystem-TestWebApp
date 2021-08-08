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
        [Key]
        public int ID { get; set; }

        //- Prowizja,
        public int Provision { get; set; }
        //- Źródło.
        public string Source { get; set; }

        public ICollection<Guest> Guests { get; set; }
    }
}
/*
new Reservation {
    Code= "",
    CreationDate= new DateTime(2020, 5, 5),
    Price= 45000,
    CheckInDate= new DateTime(2020, 6, 5),
    CheckOutDate= new DateTime(2020, 6, 7),
    CurrencyCode= "PLN",
    //ID,

    Provision= 4000,
    Source= "Facebook",
    }
/*
{
    "Code" : "aasdasdc",
    "CreationDate" : "2012-04-23T18:25:43.511Z",
    "Price" : "120",
    "CheckInDate" : "2012-04-25T18:25:43.511Z",
    "CheckOutDate" : "2012-04-26T18:25:43.511Z",
    "CurrencyCode" : "PLN"
}
*/
