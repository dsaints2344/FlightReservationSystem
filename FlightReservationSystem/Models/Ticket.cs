using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FlightReservationSystem.Models
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }

        public int FlightId { get; set; }

        public bool Paid { get; set; }


        [ForeignKey("Passenger")]
        public string PassengerId { get; set; }

        public virtual Flight Flight { get; set; }

        public virtual Passenger Passenger { get; set; }
    }
}