using System.ComponentModel.DataAnnotations;

namespace Restaurant.Models
{
    public class MenuItem
    {
        [Key]
        public int MenuId { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }
    }
}

