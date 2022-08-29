using BookingWebSite.Data.Abstract;
using BookingWebSite.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BookingWebSite.Data.Concrete.EntityFramework.Repositories
{
    public class EfUserRepository : EfEntityRepositoryBase<User>, IUserRepository
    {
        public EfUserRepository(DbContext context) : base(context)
        {
        }
    }
}
