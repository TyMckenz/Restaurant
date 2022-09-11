using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NuGet.Protocol.Core.Types;
using Restaurant.Models;

//SET IDENTITY_INSERT Reservation ON in the database to add things to it.

namespace Restaurant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly RestaurantContext _context;
        private readonly ILogger<ReservationsController> _logger;

        public ReservationsController()
        {
            _context = new RestaurantContext();
        }
        // GET: api/<ReservationsController>
        [HttpGet]
        public IEnumerable<Reservation> Get()
        {
            return _context.Reservation.ToList();
        }


        // GET api/<ReservationsController>/5
        [HttpGet("{id}")]
        public Reservation Get(int id)
        {
            return _context.Reservation.FirstOrDefault(r => r.ReserveId == id); 
        }

        // POST api/<ReservationsController>
        [HttpPost("{id}")]
        public void Post([FromBody] Reservation reservation)
        {
            if (reservation != null)
            {
                _context.Reservation.Add(reservation);
            }
            _context.SaveChanges();
        }

        // PUT api/<ReservationsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Reservation reservation)
        {
            if (id == reservation.ReserveId)
            {
                _context.Reservation.Update(reservation);
            }
            _context.SaveChanges();

            _logger.Log(LogLevel.Information, "Checking to see what is happening");
        }

        // DELETE api/<ReservationsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id, Reservation reservation)
        {
            if (id == reservation.ReserveId)
            {
                _context.Remove(id);
            }
            _context.SaveChanges();

            _logger.Log(LogLevel.Information, "Checking to see what is happening");
        }
    }
}
