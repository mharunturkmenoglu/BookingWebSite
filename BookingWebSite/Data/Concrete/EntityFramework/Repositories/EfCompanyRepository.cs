using BookingWebSite.Data.Abstract;
using BookingWebSite.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BookingWebSite.Data.Concrete.EntityFramework.Repositories
{
    public class EfCompanyRepository : EfEntityRepositoryBase<Company>, ICompanyRepository
    {
        public EfCompanyRepository(DbContext context) : base(context)
        {
        }
    }
}
