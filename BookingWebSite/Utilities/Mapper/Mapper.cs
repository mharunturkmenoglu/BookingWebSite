using BookingWebSite.Entities.Concrete;
using BookingWebSite.Entities.Dtos;

namespace BookingWebSite.Utilities.Mapper
{
    public static class Mapper
    {
        public static BookingDto BookingToDto(Booking booking, User user, Apartment apartment)
        {
            DateTime date = DateTime.Parse(booking.StartsAt);
            date.AddDays(Convert.ToDouble(booking.BookedFor));

            BookingDto dto = new BookingDto
            {
                ApartmentAddress = apartment.Address,
                ApartmentCity = apartment.City,
                ApartmentCountry = apartment.Country,
                ApartmentName = apartment.Name,
                ApartmentZipCode = apartment.ZipCode,
                BookedAt = booking.BookedAt,
                BookedFor = booking.BookedFor,
                Confirmed = booking.Confirmed,
                StartsAt = booking.StartsAt,
                UserEmail = user.Email,
                UserFirstName = user.FirstName,
                UserLastName = user.LastName,
                ExpireAt = date.ToString()
            };
            return dto;
        }
        public static Booking DtoToBooking(BookingDto dto, Booking booking)
        {
            booking.StartsAt = dto.StartsAt;
            booking.BookedAt = dto.BookedAt;
            booking.BookedFor = dto.BookedFor;
            booking.Confirmed = dto.Confirmed;

            return booking;
        }
        public static Booking DtoToBooking(BookingAddDto dto, int id)
        {
            var booking = new Booking
            {
                ApartmentId = dto.ApartmentId,
                BookedAt = dto.BookedAt,
                BookedFor = dto.BookedFor,
                Confirmed = dto.Confirmed,
                StartsAt = dto.StartsAt,
                UserId = dto.UserId,
                Id = id
            };

            return booking;
        }
        public static Booking DtoToBooking(BookingUpdateDto dto, int id)
        {
            var booking = new Booking
            {
                ApartmentId = dto.ApartmentId,
                BookedAt = dto.BookedAt,
                BookedFor = dto.BookedFor,
                Confirmed = dto.Confirmed,
                StartsAt = dto.StartsAt,
                UserId = dto.UserId,
                Id = id
            };

            return booking;
        }
    }
}
