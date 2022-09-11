using Microsoft.AspNetCore.Mvc;
using Restaurant.Models;

// SET IDENTITY_INSERT Menu ON in the database to add things to it, or add to the DB first.

namespace Restaurant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemsController : ControllerBase
    {
        private readonly RestaurantContext _context;
        private readonly ILogger<MenuItemsController> _logger;

        public MenuItemsController()
        {
            _context = new RestaurantContext();
        }

        // GET: api/<MenuItemsController>
        [HttpGet]
        public IEnumerable<MenuItem> Get()
        {
            return _context.Menu.ToList();
        }

        // GET api/<MenuItemsController>/5
        [HttpGet("{id}")]
        public MenuItem Get(int id)
        {
            return _context.Menu.FirstOrDefault(m => m.MenuId == id); ;
        }

        // POST api/<MenuItemsController>
        [HttpPost("{id}")]
        public void Post([FromBody] MenuItem item)
        {
            if (item != null)
            {
                _context.Menu.Add(item);
            }

            _context.SaveChanges();
        }

        // PUT api/<MenuItemsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] MenuItem item)
        {
            if (id == item.MenuId)
            {
                _context.Menu.Update(item);
            }
            _context.SaveChanges();
        }

        // DELETE api/<MenuItemsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id, MenuItem menuItem)
        {
            if (id == menuItem.MenuId)
            {
                _context.Remove(menuItem);
            }
            _context.SaveChanges();
        }
    }
}
