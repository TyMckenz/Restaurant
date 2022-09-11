using Microsoft.AspNetCore.Mvc;
using Restaurant.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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
