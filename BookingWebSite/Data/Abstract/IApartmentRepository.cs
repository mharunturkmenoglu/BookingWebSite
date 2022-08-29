using BookingWebSite.Entities.Abstract;
using BookingWebSite.Entities.Concrete;

namespace BookingWebSite.Data.Abstract
{
    public interface IApartmentRepository : IEntityRepository<Apartment>
    {
    }
}
