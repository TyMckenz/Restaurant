using System.ComponentModel.DataAnnotations;

namespace Restaurant.Models
{
    public class Reservation
    {
        [Key]
        public int ReserveId { get; set; }

        public string ReserveName { get; set; }

        public string ReserveDate { get; set; }

        public List<MenuItem> menuItems;
    }
}

