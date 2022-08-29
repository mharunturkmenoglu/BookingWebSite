namespace BookingWebSite.Entities.Dtos
{
    public class BookingUpdateDto
    {
        public int? UserId { get; set; }
        public string? StartsAt { get; set; }
        public string? BookedAt { get; set; }
        public int? BookedFor { get; set; }
        public string? ExpireAt { get; set; }
        public int? ApartmentId { get; set; }
        public int? Confirmed { get; set; }
    }
}
