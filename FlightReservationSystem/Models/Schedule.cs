using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace FlightReservationSystem.Models
{
    public class Schedule
    {
        public int ScheduleId { get; set; }
        public int RouteId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-mm-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DepartureDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-mm-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ArrivalDate { get; set; }

        public TimeSpan DepartureTime { get; set; }

        public TimeSpan ArrivalTime { get; set; }

        public int FlightID { get; set; }

        public string SourceId { get; set; }
        public string Source { get; set; }
        public string SourceAirport { get; set; }

        public string DestinationId { get; set; }
        public string Destination { get; set; }
        public string DestinationAirport { get; set; }



        [Required]
        public virtual Flight Flight { get; set; }
    }
}