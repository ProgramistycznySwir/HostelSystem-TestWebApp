using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HostelSystem_TestWebApp.Models
{
    public class Guest
    {
        //- Imię,
        public string Name { get; set; }
        //- Nazwisko,
        public string Surname { get; set; }
        //- E-mail,
        public string Email { get; set; }
        //- Id.
        public int ID { get; set; }

        //- Data urodzenia,
        public DateTime BirthDate { get; set; }
        //- Kod pocztowy
        public string PostalCode { get; set; }
    }
}