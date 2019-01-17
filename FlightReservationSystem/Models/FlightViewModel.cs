using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightReservationSystem.Models
{
    public class FlightViewModel
    {
        public Flight FlightVM { get; set; }
        public Schedule ScheduleVM { get; set; }
    }
}