using System;
using System.Collections.Generic;

namespace BookingWebSite.Models
{
    public partial class Booking
    {
        public int? Id { get; set; }
        public int? UserId { get; set; }
        public string? StartsAt { get; set; }
        public string? BookedAt { get; set; }
        public int? BookedFor { get; set; }
        public int? ApartmentId { get; set; }
        public int? Confirmed { get; set; }
    }
}
