using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HostelSystem_TestWebApp.Models
{
    public class Guest
    {
        //- Imię,
        [Required]
        public string Name { get; set; }
        //- Nazwisko,
        [Required]
        public string Surname { get; set; }
        //- E-mail,
        [Required]
        public string Email { get; set; }
        //- Id.
        [Key]
        public int ID { get; set; }

        //- Data urodzenia,
        public DateTime BirthDate { get; set; }
        //- Kod pocztowy
        public string PostalCode { get; set; }

        //"Telefon"
        public string PhoneNumber { get; set; }
        //"Adres"
        public string Adress { get; set; }
        //"Miasto"
        public string City { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }
}