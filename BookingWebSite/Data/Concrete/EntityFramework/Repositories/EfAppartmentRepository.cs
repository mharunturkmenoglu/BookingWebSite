using BookingWebSite.Data.Abstract;
using BookingWebSite.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BookingWebSite.Data.Concrete.EntityFramework.Repositories
{
    public class EfAppartmentRepository : EfEntityRepositoryBase<Appartment>, IAppartmentRepository
    {
        public EfAppartmentRepository(DbContext context) : base(context)
        {
        }
    }
}
