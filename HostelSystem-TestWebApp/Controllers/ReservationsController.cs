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
    public class ReservationsController : ApiController
    {
        private ReservationContext db = new ReservationContext();

        // GET: api/Reservations
        public IQueryable<Reservation> GetReservations()
        {
            return Services.ReservationManager.GetAllReservations();
        }

        // POST: api/Reservations
        public IHttpActionResult PostReservation(Reservation reservation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if(reservation == null)
                return BadRequest(ModelState);
            
            Services.ReservationManager.AddReservation(reservation);

            return CreatedAtRoute("DefaultApi", new { id = reservation.ID }, reservation);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ReservationExists(int id)
        {
            return db.Reservations.Count(e => e.ID == id) > 0;
        }
    }
}