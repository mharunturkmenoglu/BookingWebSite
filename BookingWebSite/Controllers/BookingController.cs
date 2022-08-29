using BookingWebSite.Entities.Dtos;
using BookingWebSite.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BookingWebSite.Controllers
{
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet("booking/{id:int}")]
        public async Task<ActionResult> GetBooking(int id)
        {
            var booking = await _bookingService.GetBooking(id);
            return Ok(booking);
        }
        [HttpPost("booking")]
        public async Task<ActionResult> AddBooking(BookingAddDto bookingDto)
        {
            await _bookingService.AddBooking(bookingDto);
            return Ok();
        }
        [HttpPut("booking")]
        public async Task<ActionResult> UpdateBooking(BookingUpdateDto bookingDto, int id)
        {
            await _bookingService.UpdateBooking(bookingDto, id);
            return Ok();
        }
        [HttpDelete("booking/{id:int}")]
        public async Task<ActionResult> DeleteBooking(int id)
        {
            await _bookingService.RemoveBooking(id);
            return Ok();
        }
    }
}