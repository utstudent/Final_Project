using System;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class Ticket
    {
        public Int32 TicketID { get; set; }

        [Display(Name = "Seat Number")]
        [Range(1, 20, ErrorMessage = "Seat Number must be between 1 and 20")]
        public Int32 SeatNumber { get; set; }

        public Movie Movie { get; set; }

        public Order Order { get; set; }

        public Ticket()
        {
        }
    }
}
