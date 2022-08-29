using BookingWebSite.Data.Abstract;
using BookingWebSite.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BookingWebSite.Data.Concrete.EntityFramework.Repositories
{
    public class EfApartmentRepository : EfEntityRepositoryBase<Apartment>, IApartmentRepository
    {
        public EfApartmentRepository(DbContext context) : base(context)
        {
        }
    }
}
