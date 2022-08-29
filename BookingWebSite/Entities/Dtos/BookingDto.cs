namespace BookingWebSite.Entities.Dtos
{
    public class BookingDto
    {
        public string? UserFirstName { get; set; }
        public string? UserLastName { get; set; }
        public string? UserEmail { get; set; }
        public string? StartsAt { get; set; }
        public string? BookedAt { get; set; }
        public int? BookedFor { get; set; }
        public string? ExpireAt { get; set; }
        public string? ApartmentName { get; set; }
        public string? ApartmentAddress { get; set; }
        public string? ApartmentZipCode { get; set; }
        public string? ApartmentCity { get; set; }
        public string? ApartmentCountry { get; set; }
        public int? Confirmed { get; set; }
    }
}
