using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using wayfiner_dotnet.Models;
using wayfiner_dotnet.Services;

namespace wayfiner_dotnet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TripsController : ControllerBase
    {
        private readonly TripsService _ts;
        private readonly ReservationsService _rs;

        public TripsController(TripsService ts, ReservationsService rs)
        {
            _ts = ts;
            _rs = rs;
        }

        [HttpPost]
        public ActionResult<Trip> Create([FromBody] Trip tripData)
        {
            try
            {
                Trip trip = _ts.Create(tripData);
                return Ok(trip);
            }
            catch (System.Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpGet]
        public ActionResult<List<Trip>> GetAll()
        {
            try
            {
                List<Trip> trips = _ts.GetAll();
                return Ok(trips);
            }
            catch (System.Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpGet("{id}/reservations")]
        public ActionResult<List<Reservation>> GetAllReservations(int id)
        {
            try
            {
                List<Reservation> reservations = _rs.GetAll(id);
                return Ok(reservations);
            }
            catch (System.Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}