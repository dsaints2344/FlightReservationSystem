using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FlightReservationSystem.Models
{
    public class Flight
    {
        public int FlightId { get; set; }

        public string AirlineName { get; set; }

        public string FlightClass { get; set; }

        public string FlightSeat { get; set; }

        [DataType(DataType.Currency)]
        public double FlightPrice { get; set; }

        public int TicketId { get; set; }

        public int ScheduleId { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}