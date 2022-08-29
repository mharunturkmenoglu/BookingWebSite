using BookingWebSite.Entities.Concrete;
using BookingWebSite.Entities.Dtos;

namespace BookingWebSite.Services.Abstract
{
    public interface IBookingService
    {
        Task<ICollection<BookingDto>> GetAllBookings();
        Task<BookingDto> GetBooking(int id);
        Task AddBooking(BookingAddDto bookingAddDto);
        Task UpdateBooking(BookingUpdateDto bookingUpdateDto, int id);
        Task RemoveBooking(int id);
    }
}
