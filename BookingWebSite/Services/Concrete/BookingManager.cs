using BookingWebSite.Data.Abstract;
using BookingWebSite.Entities.Concrete;
using BookingWebSite.Entities.Dtos;
using BookingWebSite.Services.Abstract;
using BookingWebSite.Utilities.Mapper;

namespace BookingWebSite.Services.Concrete
{
    public class BookingManager : IBookingService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookingManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddBooking(BookingAddDto bookingAddDto)
        {
            var booking = Mapper.DtoToBooking(bookingAddDto, 1);
            await _unitOfWork.Bookings.AddAsync(booking);
        }

        public async Task<ICollection<BookingDto>> GetAllBookings()
        {
            ICollection<Booking> bookingList =  await _unitOfWork.Bookings.GetAllAsync();
            List<Booking> bookings = new List<Booking>();
            List<BookingDto> bookingGetDtoList = new List<BookingDto>();

            foreach (var booking in bookingList)
            {
                var user = await _unitOfWork.Users.GetAsync(x=> x.Id == booking.UserId);
                var apartment = await _unitOfWork.Appartments.GetAsync(x => x.Id == booking.ApartmentId);

                var bookingGetDto = Mapper.BookingToDto(booking, user, apartment);
                bookingGetDtoList.Add(bookingGetDto);
            }
            return bookingGetDtoList;
        }

        public async Task<BookingDto> GetBooking(int id)
        {
            var booking = await _unitOfWork.Bookings.GetAsync(x => x.Id == id);

            var user = await _unitOfWork.Users.GetAsync(x => x.Id == booking.UserId);
            var apartment = await _unitOfWork.Appartments.GetAsync(x => x.Id == booking.ApartmentId);
            var bookingGetDto = Mapper.BookingToDto(booking, user, apartment);

            return bookingGetDto;
        }

        public async Task RemoveBooking(int id)
        {
            var booking = await _unitOfWork.Bookings.GetAsync(x => x.Id == id);
            if(booking != null && booking.Confirmed == 0)
                await _unitOfWork.Bookings.DeleteAsync(booking);
                await _unitOfWork.SaveAsync();
        }

        public async Task UpdateBooking(BookingUpdateDto bookingUpdateDto, int id)
        {
            
            var updateBooking = await _unitOfWork.Bookings.GetAsync(x => x.Id == id);
            if (updateBooking != null)
            {
                var booking = Mapper.DtoToBooking(bookingUpdateDto, id);
                await _unitOfWork.Bookings.UpdateAsync(booking);
                await _unitOfWork.SaveAsync();
            }
        }
    }
}
