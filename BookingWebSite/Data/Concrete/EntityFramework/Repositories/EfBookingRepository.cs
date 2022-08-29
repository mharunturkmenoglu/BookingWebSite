using BookingWebSite.Data.Abstract;
using BookingWebSite.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BookingWebSite.Data.Concrete.EntityFramework.Repositories
{
    public class EfBookingRepository : EfEntityRepositoryBase<Booking>, IBookingRepository
    {
        public EfBookingRepository(DbContext context) : base(context)
        {
        }
    }
}
