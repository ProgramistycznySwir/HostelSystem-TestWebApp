using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using HostelSystem_TestWebApp.Models;

namespace HostelSystem_TestWebApp.Controllers
{
    public class GuestsController : ApiController
    {
        private ReservationContext db = new ReservationContext();

        // GET: api/Guests
        // "metoda zrzucająca listę wszystkich gości o imieniu Piotr z miasta Wrocław lub bez miasta"
        public IQueryable<Guest> GetGuests()
        {
            return Services.ReservationManager.GetPetersFromBreslauOrNot();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GuestExists(int id)
        {
            return db.Guests.Count(e => e.ID == id) > 0;
        }
    }
}