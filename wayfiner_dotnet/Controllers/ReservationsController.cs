using Microsoft.AspNetCore.Mvc;
using wayfiner_dotnet.Models;
using wayfiner_dotnet.Services;

namespace wayfiner_dotnet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservationsController : ControllerBase
    {
        private readonly ReservationsService _rs;

        public ReservationsController(ReservationsService rs)
        {
            _rs = rs;
        }
        [HttpPost]
        public ActionResult<Reservation> Create([FromBody] Reservation reservationData)
        {
            try
            {
                Reservation reservation = _rs.Create(reservationData);
                return Ok(reservation);
            }
            catch (System.Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}